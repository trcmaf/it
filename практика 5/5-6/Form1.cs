using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_6
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
          string str = textBox1.Text;
          int len = str.Length;
          int count = 0;
          for (int i = 0; i < len; i++)
          {
          if (str[i] == str[len - 1 - i])
          count++;
          }
      if (count == len)
        label1.Text = "Слово является палиндромом";
      else label1.Text = "Слово не является палиндромом";
        }
    
    }
}
