using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_2
{
  public partial class Form1 : Form
  {
    int[,] a = new int[15, 15];
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      dataGridView1.RowCount = 5; //Указываем количество строк
      dataGridView1.ColumnCount = 5; //Указываем количество столбцов
      int i, j;
      //Заполняем матрицу случайными числами
      Random rand = new Random();
      for (i = 0; i < 5; i++)
        for (j = 0; j < 5; j++)
          a[i, j] = rand.Next(-100, 100);
      //Выводим матрицу в dataGridView1
      for (i = 0; i < 5; i++)
        for (j = 0; j < 5; j++)
          dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int max = -100;
      int min = 100;
      for (int i = 0; i < 5; i++)
        for (int j = 0; j < 5; j++)
          if (i + j == 4)
          {
            if (a[i, j] >= max) max = a[i, j];
          }

      for (int i = 0; i < 5; i++)
        for (int j = 0; j < 5; j++)
          if (i + j == 4)
          {
            if (a[i, j] <= min) min = a[i, j];
          }
      
      textBox1.Text = Convert.ToString(max);
      textBox2.Text = Convert.ToString(min);
    }
  }
}
