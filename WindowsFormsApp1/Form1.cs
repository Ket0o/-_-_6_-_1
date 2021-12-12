using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string string1 = textBox1.Text;

            string1 = string1.Replace("жы", "жи");
            string1 = string1.Replace("шы", "ши");
            string1 = string1.Replace("чя", "ча");
            string1 = string1.Replace("щя", "ща");
            string1 = string1.Replace("чю", "чу");
            string1 = string1.Replace("щю", "щу");

            string pattern = "(\\b\\w+\\b)\\s+(\\b\\w+\\b)";
            // (\b\w+\b) захватить первое слово ("\b" -Соответствует границе слова, "\w+" - Любой текстовый символ,
            // не являющийся пробелом, символом табуляции и т.п.
            // \s+ за которым следует пробел или больше (\ s+ будет соответствовать одному или нескольким символам пробела)
            // (\b\w+\b) захватить второе слово

            string repl = "$2 $1"; // $ - Соответствует концу строкового выражения
            // или концу строки при многострочном поиске (конец строки)

            string1 = Regex.Replace(string1, pattern, repl);
            textBox2.Text = string1;
        }
    }
}
