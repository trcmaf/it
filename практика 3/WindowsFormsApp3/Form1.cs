using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    private void button1_Click(object sender, EventArgs e)
    {
      // Получение исходных данных из TextBox
      double x = Convert.ToDouble(textBox1.Text);
      
      // Ввод исходных данных в окно результатов
      textBox4.Text = "Результаты работы программы ст. Соколова А.Р. " + Environment.NewLine;
      textBox4.Text += "При X = " + textBox1.Text + Environment.NewLine;
      
      // Определение номера выбранной функции
      int n = 0;
      if (radioButton2.Checked) n = 1;
      else if (radioButton3.Checked) n = 2;
      // Вычисление U
      double u;
      switch (n)
      {
        case 0:
          if (Math.Sqrt(x) > 2) u = Math.Log(Math.Sqrt(x));
          else if ((Math.Sqrt(x) > -3)&(Math.Sqrt(x) < 2)||(Math.Sqrt(x) == 2)) u = 3 * Math.Sqrt(x) - 2;
          else u = 2 + Math.Abs(Math.Sqrt(x));
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 1:
          if (Math.Exp(x) > 2) u = Math.Log(Math.Exp(x));
          else if ((Math.Exp(x) > -3) & (Math.Exp(x) < 2) || (Math.Exp(x) == 2)) u = 3 * Math.Exp(x) - 2;
          else u = 2 + Math.Abs(Math.Exp(x));
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 2:
          if (Math.Sinh(x) > 2) u = Math.Log(Math.Sinh(x));
          else if ((Math.Sinh(x) > -3) & (Math.Sinh(x) < 2) || (Math.Sinh(x) == 2)) u = 3 * Math.Sinh(x) - 2;
          else u = 2 + Math.Abs(Math.Sinh(x));
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        default:
          textBox4.Text += "Решение не найдено" + Environment.NewLine;
          break;
      }
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
