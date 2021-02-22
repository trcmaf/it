using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практическое_занятие_1_13
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      BackColor = Color.AntiqueWhite;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox1.ReadOnly = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      textBox1.ReadOnly = false;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      button1.Visible = false;
      button2.Visible = false;
      button3.Visible = false;
      button4.Visible = false;
      textBox1.Visible = false;
    }
  }
}
