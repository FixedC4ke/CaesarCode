using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace CaesarCode
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> opfreq; //используется для хранения частот символов в русском языке
        public Form1()
        {
            InitializeComponent();
        }

        public static int RusLetterToNumber(char c) //функция, возвращающая номер буквы от 1 до 33
        {
            if (c == 'ё') return 7;
            else
            {
                int tmp = (int)c - 1071;
                if (tmp > 6) return tmp + 1;
                else return tmp;
            }
        }

        public static char NumberToRusLetter(int n) //функция, возвращающая букву по ее номеру
        {
            if (n == 0) return 'я';
            if (n == 7) return 'ё';
            else
            {
                if (n > 6) return (char)(n + 1070);
                else return (char)(n + 1071);
            }
        }

        public static string Crypt(string text, int key, bool mode) //если mode == True - шифрование, False - дешифрование
        {
            int tmp = (mode?key : 33 - key); //при шифровании символ открытого текста необходимо сместить на key символов, при дешифровании на -key (33-key с учетом размера алфавита)
            string result = "";
            int code;
            foreach (char c in text.ToLower())
            {
                if (c >= 'а' && c<='ё') //если символ не является буквой русского алфавита, то он будет напечатан в незашифрованном виде
                {
                    code = (RusLetterToNumber(c) + tmp) % 33;
                    result += NumberToRusLetter(code);
                }
                else result += c;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e) //код кнопки "зашифровать"
        {
            if (richTextBox1.Text.Length == 0) { MessageBox.Show("Введите исходный текст!"); return; }
            if (textBox1.Text.Length == 0) { MessageBox.Show("Введите ключ!"); return; }
            richTextBox2.Text = Crypt(richTextBox1.Text, Int32.Parse(textBox1.Text), true);
        }

        private void button2_Click(object sender, EventArgs e)//код кнопки "расшифровать"
        {
            if (richTextBox2.Text.Length == 0) { MessageBox.Show("Введите шифртекст!"); return; }
            if (textBox1.Text.Length == 0) { MessageBox.Show("Введите ключ!"); return; }
            richTextBox1.Text = Crypt(richTextBox2.Text, Int32.Parse(textBox1.Text), false);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true; //ограничение на ввод поля "ключ": может содержать только целые числа
        }

        private void freqTextToolStripMenuItem_Click(object sender, EventArgs e) //исследуется частота появления каждой буквы в открытом тексте, после чего полученные данные сохраняются в файл.
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sr = new StreamWriter(saveFileDialog1.FileName, false))
                {
                    string result = "";
                    for (int i = 1; i <= 33; i++)
                    {
                        char c = NumberToRusLetter(i);
                        result += c.ToString()+":"+ (double)richTextBox1.Text.Count(x => x == c)/richTextBox1.Text.Length+"\n";
                    }
                    sr.Write(result);
                }
                MessageBox.Show("Файл с частотами букв открытого текста успешно сохранен");
            }
        }

        private void opentextToolStripMenuItem_Click(object sender, EventArgs e) //загрузка открытого текста из файла
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    string text = sr.ReadToEnd().ToLower();
                    richTextBox1.Text = new string(text.Where(x => (x >= 'а' && x <= 'ё') || x==' ').ToArray()).Replace("  ", ""); //из текста удаляются все символы, не являющиеся русскими буквами (за исключением пробела)
                    //при загрузке двойные пробелы удаляются   
                }
            }
        }

        private void графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Length == 0) { MessageBox.Show("Введите шифртекст!"); return; }
            Dictionary<string, double> freq2 = new Dictionary<string, double>();
            for (int i = 1; i <= 33; i++)  //исследуется частота появления каждой буквы в шифртексте, данные сохраняются в виде пар (буква, частота появления)
            {
                char c = NumberToRusLetter(i);
                freq2.Add(c.ToString(), (double)richTextBox2.Text.Count(x => x == c) / richTextBox2.Text.Length);
            }
            FreqForm freq = new FreqForm(opfreq, freq2);
            freq.ShowDialog();
        }

        private void freqsFromFileToolStripMenuItem_Click(object sender, EventArgs e) //чтение частот из файла
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                opfreq = new Dictionary<string, double>();
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] tmp = sr.ReadLine().Split(new char[] { ':' });
                        if (tmp.Length < 2)
                        {
                            MessageBox.Show("Возникла ошибка при чтении частот. Данный файл с частотами поврежден.");
                            return;
                        }
                        opfreq.Add(tmp[0], Double.Parse(tmp[1]));
                    }
                }
                toolStripStatusLabel3.Text = "загружены"; toolStripStatusLabel3.ForeColor = Color.Green;
                графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem.Enabled = attackToolStripMenuItem.Enabled = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = "| Кол-во символов открытого текста: " + richTextBox1.Text.Length;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel5.Text = "; шифртекста: " + richTextBox2.Text.Length;
        }

        private void opencrtextToolStripMenuItem_Click(object sender, EventArgs e) //загрузка шифртекста из файла (аналогично загрузке открытого текста)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    string text = sr.ReadToEnd().ToLower();
                    richTextBox2.Text = new string(text.Where(x => (x >= 'а' && x <= 'ё') || x == ' ').ToArray()).Replace("  ", "");
                }
            }
        }

        private void savetextToolStripMenuItem_Click(object sender, EventArgs e) //сохранение открытого текста
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        private void savecrtextToolStripMenuItem_Click(object sender, EventArgs e) //сохранение шифртекста
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false))
                {
                    sw.Write(richTextBox2.Text);
                }
            }
        }

        private void attackToolStripMenuItem_Click(object sender, EventArgs e) //атака на шифр
        {
            if (richTextBox2.Text.Length == 0) { MessageBox.Show("Введите шифртекст!"); return; }
            Dictionary<string, double> freq2 = new Dictionary<string, double>();
            for (int i = 1; i <= 33; i++) //исследуется частота появления каждой буквы в шифртексте, данные сохраняются в виде пар (буква, частота появления)
            {
                char c = NumberToRusLetter(i);
                freq2.Add(c.ToString(), (double)richTextBox2.Text.Count(x => x == c) / richTextBox2.Text.Length);
            }
            var item1 = opfreq.OrderByDescending(pair => pair.Value).Select(x => x.Key).Take(1).ToArray(); //выбирается наиболее часто встречающаяся буква открытого текста
            var item2 = freq2.OrderByDescending(pair => pair.Value).Select(x => x.Key).Take(1).ToArray(); // ...шифртекста
            int code = RusLetterToNumber(Char.Parse(item2[0]))-RusLetterToNumber(Char.Parse(item1[0])); //вычисляется ключ
            textBox1.Text = (code >= 0 ? code.ToString() : (33 + code).ToString()); //ключ вводится в поле "ключ"
        }
    }
}
