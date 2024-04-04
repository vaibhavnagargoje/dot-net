﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            if (str.Length == 0 || str[str.Length - 1] == '.' || str[str.Length - 1] == '+' || str[str.Length - 1] == '-' || str[str.Length - 1] == '*' || str[str.Length - 1] == '/')
                return;
            textBox1.Text += '/';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            if (str.Length == 0 || str[str.Length - 1] == '.' || str[str.Length - 1] == '+' || str[str.Length - 1] == '-' || str[str.Length - 1] == '*' || str[str.Length - 1] == '/')
                return;
            textBox1.Text += '*';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            //if (str.Length == 0 || str[str.Length - 1] == '.' || str[str.Length - 1] == '+' || str[str.Length - 1] == '-' || str[str.Length - 1] == '*' || str[str.Length - 1] == '/')
             //   return;
            textBox1.Text += '-';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            if (str.Length == 0 || str[str.Length - 1] == '.' || str[str.Length - 1] == '+' || str[str.Length - 1] == '-' || str[str.Length - 1] == '*' || str[str.Length - 1] == '/')
                return;
            textBox1.Text += '+';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            if (str.Length == 0 || str[str.Length - 1] == '.' || str[str.Length - 1] == '+' || str[str.Length - 1] == '-' || str[str.Length - 1] == '*' || str[str.Length - 1] == '/')
                return;
            textBox1.Text += '.';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += '0';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = new System.Data.DataTable().Compute(textBox1.Text, null).ToString();
        }
    }
}