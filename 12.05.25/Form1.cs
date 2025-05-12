using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._05._25
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        List<char> marks = new List<char>();
        string a = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a += '1';
            textBox1.Text = a;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            a += '4';
            textBox1.Text = a;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (a != "")
            {
                int n = Convert.ToInt32(a);
                numbers.Add(n);
                a = "";
                if (numbers.Count == 2)
                {
                    int answer = 0;
                    if (marks[0] == '+')
                    {
                        answer = numbers[0] + numbers[1];
                    }
                    if (marks[0] == '-')
                    {
                        answer = numbers[0] - numbers[1];
                    }
                    if (marks[0] == '*')
                    {
                        answer = numbers[0] * numbers[1];
                    }
                    if (marks[0] == '/')
                    {
                        answer = numbers[0] / numbers[1];
                    }
                    textBox1.Text = Convert.ToString(answer);
                    numbers.RemoveAt(0);
                    numbers.RemoveAt(0);
                    numbers.Add(answer);
                    marks.RemoveAt(0);
                }
            }
            marks.Add('*');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (a != "")
            {
                int n = Convert.ToInt32(a);
                numbers.Add(n);
                a = "";
                if (numbers.Count == 2)
                {
                    int answer = 0;
                    if (marks[0] == '+')
                    {
                        answer = numbers[0] + numbers[1];
                    }
                    if (marks[0] == '-')
                    {
                        answer = numbers[0] - numbers[1];
                    }
                    if (marks[0] == '*')
                    {
                        answer = numbers[0] * numbers[1];
                    }
                    if (marks[0] == '/')
                    {
                        answer = numbers[0] / numbers[1];
                    }
                    textBox1.Text = Convert.ToString(answer);
                    numbers.RemoveAt(0);
                    numbers.RemoveAt(0);
                    numbers.Add(answer);
                    marks.RemoveAt(0);
                }
            }
            marks.Add('-');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (a != "")
            {
                int n = Convert.ToInt32(a);
                numbers.Add(n);
                a = "";
                if (numbers.Count == 2)
                {
                    int answer = 0;
                    if (marks[0] == '+')
                    {
                        answer = numbers[0] + numbers[1];
                    }
                    if (marks[0] == '-')
                    {
                        answer = numbers[0] - numbers[1];
                    }
                    if (marks[0] == '*')
                    {
                        answer = numbers[0] * numbers[1];
                    }
                    if (marks[0] == '/')
                    {
                        answer = numbers[0] / numbers[1];
                    }
                    textBox1.Text = Convert.ToString(answer);
                    numbers.RemoveAt(0);
                    numbers.RemoveAt(0);
                    numbers.Add(answer);
                    marks.RemoveAt(0);
                }
            }
            marks.Add('+');

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (a != "")
            {
                int n = Convert.ToInt32(a);
                numbers.Add(n);
                a = "";
                if (numbers.Count == 2)
                {
                    int answer = 0;
                    if (marks[0] == '+')
                    {
                        answer = numbers[0] + numbers[1];
                    }
                    if (marks[0] == '-')
                    {
                        answer = numbers[0] - numbers[1];
                    }
                    if (marks[0] == '*')
                    {
                        answer = numbers[0] * numbers[1];
                    }
                    if (marks[0] == '/')
                    {
                        answer = numbers[0] / numbers[1];
                    }
                    textBox1.Text = Convert.ToString(answer);
                    numbers.RemoveAt(0);
                    numbers.RemoveAt(0);
                    numbers.Add(answer);
                    marks.RemoveAt(0);
                }
            }
            marks.Add('/');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a += '5';
            textBox1.Text = a;

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            a += '6';
            textBox1.Text = a;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a += '2';
            textBox1.Text = a;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            a += '3';
            textBox1.Text = a;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            a += '7';
            textBox1.Text = a;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            a += '8';
            textBox1.Text = a;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            a += '9';
            textBox1.Text = a;

        }

        private void button0_Click(object sender, EventArgs e)
        {
            a += '0';
            textBox1.Text = a;

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            a = "";
            textBox1.Text = a;
            numbers.Clear();
            marks.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(a);
            numbers.Add(n);
            a = "";
            int answer = 0;
            if (marks[0]== '+')
            {
                answer = numbers[0] + numbers[1];
            }
            if (marks[0] == '-')
            {
                answer = numbers[0] - numbers[1];
            }
            if (marks[0] == '*')
            {
                answer = numbers[0] * numbers[1];
            }
            if (marks[0] == '/')
            {
                answer = numbers[0] / numbers[1];
            }
            textBox1.Text = Convert.ToString(answer);
            numbers.RemoveAt(0);
            numbers.RemoveAt(0);
            numbers.Add(answer);
            marks.RemoveAt(0);
        }
    }
}
