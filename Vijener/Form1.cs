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

namespace Vijener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public int RusLetterToNumber(char c)
        {
            if (c == 'ё') return 7;
            else
            {
                int tmp = (int)c - 1071;
                if (tmp > 6) return tmp + 1;
                else return tmp;
            }
        }

        public char NumberToRusLetter(int n)
        {
            if (n == 0) return 'я';
            if (n == 7) return 'ё';
            else
            {
                if (n > 6) return (char)(n + 1070);
                else return (char)(n + 1071);
            }
        }

        private string Crypt(string text, int key, bool mode)
        {
            int tmp = (mode?key : 33 - key);
            string result = "";
            int code;
            foreach (char c in text.ToLower())
            {
                if (c != ' ')
                {
                    code = (RusLetterToNumber(c) + tmp) % 33;
                    result += NumberToRusLetter(code);
                }
                else result += c;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0) { MessageBox.Show("Введите исходный текст!"); return; }
            if (textBox1.Text.Length == 0) { MessageBox.Show("Введите ключ!"); return; }
            richTextBox2.Text = Crypt(richTextBox1.Text, Int32.Parse(textBox1.Text), true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Length == 0) { MessageBox.Show("Введите шифртекст!"); return; }
            if (textBox1.Text.Length == 0) { MessageBox.Show("Введите ключ!"); return; }
            richTextBox1.Text = Crypt(richTextBox2.Text, Int32.Parse(textBox1.Text), false);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'а' || e.KeyChar > 'я') && e.KeyChar != ' ') e.Handled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void freqTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FreqForm freq = new FreqForm(richTextBox1.Text);
            freq.Show();
        }
    }
}
