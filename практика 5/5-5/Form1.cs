﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_5
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
      int i = 0;
      while (i < len)
      {
        label1.Text += str[len - i - 1];
        i++;
      }
     }

    private void button2_Click(object sender, EventArgs e)
    {
      label1.Text = "";
    }
  }
}
