﻿using System;
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
        private Dictionary<string, double> opfreq;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public static int RusLetterToNumber(char c)
        {
            if (c == 'ё') return 7;
            else
            {
                int tmp = (int)c - 1071;
                if (tmp > 6) return tmp + 1;
                else return tmp;
            }
        }

        public static char NumberToRusLetter(int n)
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
            toolStripProgressBar1.Maximum = text.Length;
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Step = 1;
            foreach (char c in text.ToLower())
            {
                if (c >= 'а' && c<='ё')
                {
                    code = (RusLetterToNumber(c) + tmp) % 33;
                    result += NumberToRusLetter(code);
                }
                else result += c;
                toolStripProgressBar1.PerformStep();
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
            }
        }

        private void opentextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    string text = sr.ReadToEnd().ToLower();
                    richTextBox1.Text = new string(text.Where(x => (x >= 'а' && x <= 'ё') || x==' ').ToArray()).Replace("  ", "");
                }
            }
        }

        private void графикЧастотБуквРусскогоЯзыкаИШифртекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> freq2 = new Dictionary<string, double>();
            for (int i = 1; i <= 33; i++)
            {
                char c = NumberToRusLetter(i);
                freq2.Add(c.ToString(), (double)richTextBox2.Text.Count(x => x == c) / richTextBox2.Text.Length);
            }
            FreqForm freq = new FreqForm(opfreq, freq2);
        }

        private void freqsFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                opfreq = new Dictionary<string, double>();
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {

                }
            }
        }
    }
}
