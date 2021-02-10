namespace WindowsFormsApp1
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.Navy;
      this.button1.Location = new System.Drawing.Point(29, 231);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(109, 42);
      this.button1.TabIndex = 0;
      this.button1.Text = "Посчитать";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(29, 97);
      this.textBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(149, 29);
      this.textBox1.TabIndex = 1;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(318, 97);
      this.textBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(143, 29);
      this.textBox2.TabIndex = 2;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(141, 349);
      this.textBox3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(217, 29);
      this.textBox3.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(11, 61);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(191, 21);
      this.label1.TabIndex = 4;
      this.label1.Text = "Введите первое число: \r\n";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(300, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(191, 21);
      this.label2.TabIndex = 5;
      this.label2.Text = "Введите второе число: ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(207, 301);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(97, 21);
      this.label3.TabIndex = 6;
      this.label3.Text = "Результат: ";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.Navy;
      this.label4.Location = new System.Drawing.Point(161, 148);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(181, 21);
      this.label4.TabIndex = 7;
      this.label4.Text = "Выберите операцию";
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.ForeColor = System.Drawing.Color.Navy;
      this.button2.Location = new System.Drawing.Point(365, 231);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(96, 42);
      this.button2.TabIndex = 8;
      this.button2.Text = "Очистить";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
      this.comboBox1.Location = new System.Drawing.Point(195, 183);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(109, 29);
      this.comboBox1.TabIndex = 9;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.ClientSize = new System.Drawing.Size(512, 468);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Cursor = System.Windows.Forms.Cursors.Default;
      this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.MediumBlue;
      this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.Name = "Form1";
      this.Text = "Практическая работа N1. ";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ComboBox comboBox1;
  }
}

