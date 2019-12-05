using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float a, b;
        char k;

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            b = Convert.ToSingle(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            b = Convert.ToSingle(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            b = Convert.ToSingle(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            b = Convert.ToSingle(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            b = Convert.ToSingle(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            b = Convert.ToSingle(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            b = Convert.ToSingle(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            b = Convert.ToSingle(textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            b = Convert.ToSingle(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            b = Convert.ToSingle(textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Convert.ToSingle(textBox1.Text);
                textBox1.Text = "";
                k = '+';

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Convert.ToSingle(textBox1.Text);
                k = '-';
                textBox1.Text = "";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Convert.ToSingle(textBox1.Text);
                k = '*';
                textBox1.Text = "";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Convert.ToSingle(textBox1.Text);
                k = '/';
                textBox1.Text = "";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (k)
            { // начало оператора множественного выбора с переменной k
                case '+':
                    a = a + b;// если переменная k имеет значение + то переменная a присваивает значение a+b
                    textBox1.Text = Convert.ToString(a);
                    break;// переменная a конвертируется в строку и выводится на экран в окошке Edit1
                case '-':
                    a = a - b; // если переменная k имеет значение - то переменная a присваивает значение a-b
                    textBox1.Text = Convert.ToString(a);
                    break;// переменная a конвертируется в строку и выводится на экран в окошке Edit1
                case '*':
                    a = a * b;// если переменная k имеет значение * то переменная a присваивает значение a*b
                    textBox1.Text = Convert.ToString(a);
                    break;// переменная a конвертируется в строку и выводится на экран в окошке Edit1
                case '/':
                    a = a / b;// если переменная k имеет значение / то переменная a присваивает значение a/b
                    textBox1.Text = Convert.ToString(a);
                    break; // переменная a конвертируется в строку и выводится на экран в окошке Edit1
            }// конец оператора множественного выбора
        }
    }
}
