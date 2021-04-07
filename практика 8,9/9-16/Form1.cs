using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_16
{
  public partial class Form1 : Form
  {
    Point[] points = new Point[50];
    Point[] cpoints = new Point[10];
    Pen pen = new Pen(Color.Black, 2);
    Pen greenpen = new Pen(Color.Green, 6);
    Pen bluepen = new Pen(Color.Blue, 3);
    Pen dpen = new Pen(Color.Coral, 3);
    SolidBrush solidbrush = new SolidBrush(Color.Red);
    HatchBrush hatchbrush = new HatchBrush(HatchStyle.Cross, Color.Orchid, Color.LightSkyBlue);

    public Form1()
    {
      InitializeComponent();
    }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
      Graphics g = e.Graphics;
      
      g.DrawRectangle(pen, 30, 4, 100, 150);
      g.DrawEllipse(greenpen, 80, 90, 200, 100);
      g.DrawClosedCurve(bluepen, cpoints);
      g.FillRectangle(hatchbrush, 300, 20, 150, 150);
      g.FillEllipse(solidbrush, 40, 200, 160, 160);
      dpen.DashStyle = DashStyle.Dash;
      g.DrawRectangle(dpen, 220, 200, 300, 80);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      for (int i = 0; i < 20; i++)
      {
        int xPos;
        if (i % 2 == 0)
        {
          xPos = 10;
        }
        else
        {
          xPos = 400;
        }
        points[i] = new Point(xPos, 10 * i);
      }
      for (int i = 0; i < 10; i++)
      {
        int x1Pos;
        if (i % 3 == 0)
        {
          x1Pos = 150;
        }
        else
        {
          x1Pos = 200;
        }
        cpoints[i] = new Point(x1Pos, 18 * i);
      }
    }
  }
}
