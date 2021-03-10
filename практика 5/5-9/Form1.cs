using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_9
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      int index = listBox1.SelectedIndex;
      string str = (string)listBox1.Items[index];
      int len = str.Length;
      int count1 = 0;
      int count2 = 0;
      bool res = true;
      for (int i = 0; i < len; i++)
      {
        if (str[i] == '(') count1++;
        if (str[i] == ')') count2++;
        if (count2 > count1) res = false;
      }
      if (count1 != count2) res = false;
      if (res == true) label1.Text = "Скобки расставлены правильно";
      else label1.Text = "Скобки расставлены неправильно";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      label1.Text = "";
    }
  }
}
