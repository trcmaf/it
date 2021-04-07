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
    private int x1, y1, x2, y2, r;
    int[] Mas = new int[100];
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      //g.DrawLine(pen, x1, y1, x2, y2); //рисуем секундную стрелку
      g.DrawRectangle(pen, x1, y1, 20, 20);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      for(int i = 0; i < 100; i++)
            {
                x1 = Mas[i];
                y1 = 5;
                Invalidate();
                /*if (i > 10)
                {
                    y1 = Mas[i];
                    Invalidate();
                }*/
                    

            }
      /*while(b <= 5)
      {
      x1 = x1 + 1;
      y1 = y1 + 1;
      Invalidate(); //вынудительный вызов перерисовки (Paint)
      b++;
      }
      while((b > 5) && (b < 10))
      {
        x1 = x1 + 5;
        y1 = y1 - 1;
        Invalidate(); //вынудительный вызов перерисовки (Paint)
        b++;
      }*/

      //a -= 0.1;//уменьшаем угол на 0,1 радиану
               //определяем конец часовой стрелки с учетом центра экрана
      //x2 = x1 + (int)(r * Math.Cos(a));
      //y2 = y1 - (int)(r * Math.Sin(a));
      
    }

    //private double a;
    private Pen pen = new Pen(Color.Red, 2);
    public Form1()
    {
      InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {
      x1 = ClientSize.Width / 40;
      y1 = ClientSize.Height / 40;
      //x1 = ClientSize.Width / 2;
      //y1 = ClientSize.Height / 2;
      //r = 150; //задаем радиус
      //a = 0; //задаем угол поворота
             //определяем конец часовой стрелки с учетом центра экрана
      //x2 = x1 + (int)(r * Math.Cos(a));
      //y2 = y1 - (int)(r * Math.Sin(a));
      for(int i = 0; i < 100; i++)
      {
        Mas[i] = i;
      }
    }
    }
}
