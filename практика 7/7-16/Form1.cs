using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_16
{
  public partial class Form1 : Form
  {
    int[,] a = new int[5, 5];
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = -100;
            int maxst = 0;
            int min = 100;
            int minst = 0;
            for (int i = 0; i < 5; i++)
               for (int j = 0; j < 5; j++)
                 if (a[i, j] >= max)
                 {
                    max = a[i, j];
                    maxst = j;
                 }
      for (int i = 0; i < 5; i++)
        for (int j = 0; j < 5; j++)
          if (a[i, j] <= min)
          {
            min = a[i, j];
            minst = j;
          }

            for (int i = 0; i < 5; i++)
            {
                 dataGridView1.Rows[i].Cells[maxst].Value = 0;
            }
      
            for (int i = 0; i < 5; i++)
            {
                 dataGridView1.Rows[i].Cells[minst].Value = 0;
            }
                 
    }

    private void button2_Click(object sender, EventArgs e)
    {
            dataGridView1.RowCount = 5; //Указываем количество строк
            dataGridView1.ColumnCount = 5; //Указываем количество столбцов
            //int[,] a = new int[5, 5]; //Инициализируем массив
            int i, j;
            
            Random rand = new Random();
            for (i = 0; i < 5; i++)
               for (j = 0; j < 5; j++)
                 a[i, j] = rand.Next(-100, 100);
      
            for (i = 0; i < 5; i++)
               for (j = 0; j < 5; j++)
                 dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
    }
  }
}
