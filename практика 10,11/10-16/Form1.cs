using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_16
{
  public partial class Form1 : Form
    
  {
    
    float x1, y1;
    float[,] Mas = new float[100,2];
    int i = 0;
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      //g.DrawLine(pen, x1, y1, x2, y2); //рисуем секундную стрелку
      g.DrawRectangle(pen, x1, y1, 40, 40);
    }
    private Pen pen = new Pen(Color.Red, 2);
    public void timer1_Tick(object sender, EventArgs e)
    {
      i += 1;
      if (i == 99) timer1.Enabled = false;
      x1 = Mas[i, 0];
      y1 = Mas[i, 1];
      Invalidate();
      

      /*  for (int i = 0; i < 100; i++)
        {
          Mas[i, 0] = i^3 - i^2;

        }
        for (int i = 0; i < 100; i++)
        {
          Mas[i, 1] = i ^ 3 - i ^ 2;

        }
        for (int i = 0; i < 100; i++)
        {
          x1 = Mas[i, 0];
          y1 = Mas[i, 1];
          Invalidate();
        }*/
    }

    public Form1()
    {
      InitializeComponent();
      
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //x1 = ClientSize.Width / 2;
      //y1 = ClientSize.Height / 2;
      for (int i = 0; i < 100; i++)
      {
        Mas[i, 0] = ClientSize.Width / 3 + i - 4;
      }
      for (int i = 0; i < 100; i++)
      {
        Mas[i, 1] = ClientSize.Height / 3 + i - 4;
      }

    }
  }
}
