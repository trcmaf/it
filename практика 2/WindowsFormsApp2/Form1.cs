﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "2";
            // Вывод строки в многострочный редактор
            textBox2.Text = "Практическая работа №2 Соколова А.Р.";
            textBox2.Text += Environment.NewLine + "Рассчитать значение выражения y = x ^ 2";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения X
            double x = double.Parse(textBox1.Text);
            // Вывод значения X в окно
            textBox2.Text += Environment.NewLine +
            "При x = " + x.ToString();
            // Вычисляем арифметическое выражение
            double y = Math.Pow(x, 2);

            // Выводим результат в окно
            textBox2.Text += Environment.NewLine +
            "Результат y = " + y.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
