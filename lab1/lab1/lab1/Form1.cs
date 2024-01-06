﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char Operator;
        double res = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            op1 = this.textBox1.Text;
            Operator = '*';
            input = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            op1 = this.textBox1.Text;
            Operator = '%';
            input = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op1 = this.textBox1.Text;
            Operator = '/';
            input = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op1 = this.textBox1.Text;
            Operator = '-';
            input = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "1";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "2";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "3";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "4";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "5";
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "6";
            this.textBox1.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "7";
            this.textBox1.Text += input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "8";
            this.textBox1.Text += input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "9";
            this.textBox1.Text += input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "0";
            this.textBox1.Text += input;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            op1 = this.textBox1.Text;
            Operator = '+';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
           
            
            
            double num1, num2;
            double.TryParse(op1, out num1);
            double.TryParse(op2, out num2);
            if (Operator == 's')
            {
                res = Math.Sqrt(num1);
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == '1')
            {
                res = Math.Log10(num1);
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == '!')
            {    res =1;
                for (int i = (int)num1; i > 0; i--)
                {
                    res = res * i;
                }
                
                this.textBox1.Text = res.ToString();
            }
           
            
            op2 = input;
            if (Operator == '+')
            {
                res = num1 + num2;
                this.textBox1.Text = res.ToString();
            }

            else if (Operator == '-')
            {
                res = num1 - num2;
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == '*')
            {
                res = num1 * num2;
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == '/')
            {
                if (num2 != 0)
                {
                    res = num1 / num2;
                    this.textBox1.Text = res.ToString();
                }
                else
                {
                    textBox1.Text = "division by zero";
                }
            }
            else if (Operator == '%')
            {
                res = num1 % num2;
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == '^')
            {
                res = Math.Pow(num1, num2);
                this.textBox1.Text = res.ToString();
            }
            
            input = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            op1 = string.Empty;
            op2 = string.Empty;
            this.textBox1.Text = string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            op1 = this.textBox1.Text;
            Operator = 's';
            input = string.Empty;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            op1 = this.textBox1.Text;
            Operator = '^';
            input = string.Empty;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            op1 = this.textBox1.Text;
            Operator = '!';
            input = string.Empty;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            op1 = this.textBox1.Text;
            Operator = 'l';
            input = string.Empty;
        }
    }
}
