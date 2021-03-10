using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    int[] Mas = new int[15];
    public Form1()
    {
      InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      richTextBox1.Text = "";
      for (int i = 0; i < 15; i++)
      {
        Mas[i] = rand.Next(-50, 50);
        richTextBox1.Text += "Mas[" + Convert.ToString(i) + "] = "
        + Convert.ToString(Mas[i]) + Environment.NewLine;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      richTextBox2.Text = "";
      int sum = 0;
      for (int i = 0; i < 15; i++)
      {
        if (Mas[i] % 6 == 0) sum += Mas[i];
      }
      richTextBox2.Text = sum.ToString();
    }
  }
}
