﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_16
{
  public partial class Form1 : Form
  {
    //Объявляем переменные доступные в каждом обработчике события
    private Point PreviousPoint, point; //Точка до перемещения курсора мыши и текущая точка
    private Bitmap bmp;
    private Pen blackPen;
    private Graphics g;
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //открытие файла
      OpenFileDialog dialog = new OpenFileDialog(); //описываем и порождаем объект dialog класса OpenFileDialog
                                                    //задаем расширения файлов
      dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
      if (dialog.ShowDialog() == DialogResult.OK)//вызываем диалоговое окно и проверяем выбран ли файл
      {
        Image image = Image.FromFile(dialog.FileName); //Загружаем в image изображение из выбранного файла
        int width = image.Width;
        int height = image.Height;
        pictureBox1.Width = width;
        pictureBox1.Height = height;
        bmp = new Bitmap(image, width, height); //создаем и загружаем из image изображение в формате bmp
        pictureBox1.Image = bmp; //записываем изображение в формате bmp в pictureBox1
        g = Graphics.FromImage(pictureBox1.Image); //подготавливаем объект Graphics для рисования в pictureBox1
      }
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      PreviousPoint.X = e.X;
      PreviousPoint.Y = e.Y;
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left) //Проверяем нажата ли левая кнопка мыши
      { 
        point.X = e.X;
        point.Y = e.Y;
        
        g.DrawLine(blackPen, PreviousPoint, point);
        
        PreviousPoint.X = point.X;
        PreviousPoint.Y = point.Y;
        pictureBox1.Invalidate();//Принудительно вызываем переррисовку pictureBox1
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < bmp.Width / 3; i++)
        for (int j = 0; j < bmp.Height; j++)
        {
          Color color = bmp.GetPixel(i, j);
          bmp.SetPixel(i, j, Color.FromArgb(color.A, color.R, 0, 0));
        }
            for (int i = bmp.Width / 3; i < 2 * bmp.Width / 3; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j, Color.FromArgb(color.A, 0, color.G, 0));
                }
            for (int i = 2 * bmp.Width / 3; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j, Color.FromArgb(color.A, 0, 0, color.B));
                }
            Refresh();
    }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
            "Bitmap File(*.bmp)|*.bmp|" +
            "GIF File(*.gif)|*.gif|" +
            "JPEG File(*.jpg)|*.jpg|" +
            "TIF File(*.tif)|*.tif|" +
            "PNG File(*.png)|*.png";
            savedialog.ShowHelp = true;
            // If selected, save
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                // в строку fileName записываем указанный в savedialog полный путь к файлу
                string fileName = savedialog.FileName;
                // Убираем из имени три последних символа (расширение файла)
                string strFilExtn =
                fileName.Remove(0, fileName.Length - 3);
                // Сохраняем файл в нужном формате и с нужным расширением
                switch (strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      blackPen = new Pen(Color.Black, 4); //подготавливаем перо для рисования
    }

    }
}
