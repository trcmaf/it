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
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      int index = listBox1.SelectedIndex;
      string str = (string)listBox1.Items[index];
      int len = str.Length;
      int count = 0;
      for (int i = 0; i < len; i++)
      {
        if ((str[i] == '!') || (str[i] == '?') || (str[i] == '.'))
          count++;
      }
      label1.Text = "Количество предложений = " + count.ToString();
    }
    }
}
