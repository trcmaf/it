using System;
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
            
            // Вывод строки в многострочный редактор
            textBox2.Text = "Практическая работа №2 Соколова А.Р.";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения X
            double x = double.Parse(textBox1.Text);
            // Вывод значения X в окно
            textBox2.Text += Environment.NewLine +
            "При x = " + x.ToString();
            // Вычисляем арифметическое выражение
            double y = (2*Math.Log(Math.Sqrt(x))-3*((x + 1)/(2*x + 3)))/(Math.Sin(2*x)* Math.Sin(2*x) + Math.Abs(Math.Exp(2*x) - 3*(x*x)));

            // Выводим результат в окно
            textBox2.Text += Environment.NewLine + "Результат y = " + y.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
