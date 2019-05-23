namespace _1laba
{
    partial class Form_Graphics_Editor
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
            this.pictureBox_Editor = new System.Windows.Forms.PictureBox();
            this.GBShp = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hexagon = new System.Windows.Forms.RadioButton();
            this.Octagon = new System.Windows.Forms.RadioButton();
            this.Ellipse = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Triangle = new System.Windows.Forms.RadioButton();
            this.TrackBar_Width = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.PanCol = new System.Windows.Forms.Panel();
            this.List_Drawn_Figures = new System.Windows.Forms.ComboBox();
            this.TBX1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBY1 = new System.Windows.Forms.TextBox();
            this.TBX2 = new System.Windows.Forms.TextBox();
            this.TBY2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBPW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьИщображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Editor)).BeginInit();
            this.GBShp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Width)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Editor
            // 
            this.pictureBox_Editor.BackColor = System.Drawing.Color.White;
            this.pictureBox_Editor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Editor.Location = new System.Drawing.Point(179, 44);
            this.pictureBox_Editor.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Editor.Name = "pictureBox_Editor";
            this.pictureBox_Editor.Size = new System.Drawing.Size(836, 647);
            this.pictureBox_Editor.TabIndex = 0;
            this.pictureBox_Editor.TabStop = false;
            this.pictureBox_Editor.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox_Editor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox_Editor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox_Editor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // GBShp
            // 
            this.GBShp.Controls.Add(this.label1);
            this.GBShp.Controls.Add(this.Hexagon);
            this.GBShp.Controls.Add(this.Octagon);
            this.GBShp.Controls.Add(this.Ellipse);
            this.GBShp.Controls.Add(this.Rectangle);
            this.GBShp.Controls.Add(this.Line);
            this.GBShp.Controls.Add(this.Triangle);
            this.GBShp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GBShp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBShp.Location = new System.Drawing.Point(0, 37);
            this.GBShp.Margin = new System.Windows.Forms.Padding(4);
            this.GBShp.Name = "GBShp";
            this.GBShp.Padding = new System.Windows.Forms.Padding(4);
            this.GBShp.Size = new System.Drawing.Size(179, 208);
            this.GBShp.TabIndex = 5;
            this.GBShp.TabStop = false;
            this.GBShp.Text = "Выбор фигуры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Width";
            // 
            // Hexagon
            // 
            this.Hexagon.AutoSize = true;
            this.Hexagon.Location = new System.Drawing.Point(8, 164);
            this.Hexagon.Margin = new System.Windows.Forms.Padding(4);
            this.Hexagon.Name = "Hexagon";
            this.Hexagon.Size = new System.Drawing.Size(136, 22);
            this.Hexagon.TabIndex = 11;
            this.Hexagon.TabStop = true;
            this.Hexagon.Text = "Шестиугольник";
            this.Hexagon.UseVisualStyleBackColor = true;
            // 
            // Octagon
            // 
            this.Octagon.AutoSize = true;
            this.Octagon.Location = new System.Drawing.Point(8, 135);
            this.Octagon.Margin = new System.Windows.Forms.Padding(4);
            this.Octagon.Name = "Octagon";
            this.Octagon.Size = new System.Drawing.Size(146, 22);
            this.Octagon.TabIndex = 10;
            this.Octagon.TabStop = true;
            this.Octagon.Text = "Восьмиугольник";
            this.Octagon.UseVisualStyleBackColor = true;
            // 
            // Ellipse
            // 
            this.Ellipse.AutoSize = true;
            this.Ellipse.Location = new System.Drawing.Point(8, 79);
            this.Ellipse.Margin = new System.Windows.Forms.Padding(4);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(82, 22);
            this.Ellipse.TabIndex = 9;
            this.Ellipse.TabStop = true;
            this.Ellipse.Text = "Эллипс";
            this.Ellipse.UseVisualStyleBackColor = true;
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(8, 52);
            this.Rectangle.Margin = new System.Windows.Forms.Padding(4);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(139, 22);
            this.Rectangle.TabIndex = 8;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Прямоугольник";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(8, 23);
            this.Line.Margin = new System.Windows.Forms.Padding(4);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(72, 22);
            this.Line.TabIndex = 7;
            this.Line.TabStop = true;
            this.Line.Text = "Линия";
            this.Line.UseVisualStyleBackColor = true;
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Location = new System.Drawing.Point(8, 107);
            this.Triangle.Margin = new System.Windows.Forms.Padding(4);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(117, 22);
            this.Triangle.TabIndex = 6;
            this.Triangle.TabStop = true;
            this.Triangle.Text = "Треугольник";
            this.Triangle.UseVisualStyleBackColor = true;
            // 
            // TrackBar_Width
            // 
            this.TrackBar_Width.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrackBar_Width.Location = new System.Drawing.Point(0, 338);
            this.TrackBar_Width.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBar_Width.Name = "TrackBar_Width";
            this.TrackBar_Width.Size = new System.Drawing.Size(164, 56);
            this.TrackBar_Width.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 316);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Толщина линии:";
            // 
            // PanCol
            // 
            this.PanCol.BackColor = System.Drawing.Color.Black;
            this.PanCol.Location = new System.Drawing.Point(133, 266);
            this.PanCol.Margin = new System.Windows.Forms.Padding(4);
            this.PanCol.Name = "PanCol";
            this.PanCol.Size = new System.Drawing.Size(21, 21);
            this.PanCol.TabIndex = 15;
            this.PanCol.Click += new System.EventHandler(this.PanCol_Click);
            // 
            // List_Drawn_Figures
            // 
            this.List_Drawn_Figures.FormattingEnabled = true;
            this.List_Drawn_Figures.Location = new System.Drawing.Point(9, 420);
            this.List_Drawn_Figures.Margin = new System.Windows.Forms.Padding(4);
            this.List_Drawn_Figures.Name = "List_Drawn_Figures";
            this.List_Drawn_Figures.Size = new System.Drawing.Size(145, 24);
            this.List_Drawn_Figures.TabIndex = 17;
            this.List_Drawn_Figures.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TBX1
            // 
            this.TBX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBX1.Location = new System.Drawing.Point(9, 466);
            this.TBX1.Margin = new System.Windows.Forms.Padding(4);
            this.TBX1.Name = "TBX1";
            this.TBX1.Size = new System.Drawing.Size(54, 24);
            this.TBX1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(71, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "коорд. X1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(71, 502);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "коорд. Y1";
            // 
            // TBY1
            // 
            this.TBY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBY1.Location = new System.Drawing.Point(9, 498);
            this.TBY1.Margin = new System.Windows.Forms.Padding(4);
            this.TBY1.Name = "TBY1";
            this.TBY1.Size = new System.Drawing.Size(54, 24);
            this.TBY1.TabIndex = 21;
            // 
            // TBX2
            // 
            this.TBX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBX2.Location = new System.Drawing.Point(9, 530);
            this.TBX2.Margin = new System.Windows.Forms.Padding(4);
            this.TBX2.Name = "TBX2";
            this.TBX2.Size = new System.Drawing.Size(54, 24);
            this.TBX2.TabIndex = 22;
            // 
            // TBY2
            // 
            this.TBY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBY2.Location = new System.Drawing.Point(9, 562);
            this.TBY2.Margin = new System.Windows.Forms.Padding(4);
            this.TBY2.Name = "TBY2";
            this.TBY2.Size = new System.Drawing.Size(54, 24);
            this.TBY2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(71, 535);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "коорд. X2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(71, 566);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "коорд. Y2";
            // 
            // TBPW
            // 
            this.TBPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPW.Location = new System.Drawing.Point(9, 594);
            this.TBPW.Margin = new System.Windows.Forms.Padding(4);
            this.TBPW.Name = "TBPW";
            this.TBPW.Size = new System.Drawing.Size(54, 24);
            this.TBPW.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(71, 598);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "толщина";
            // 
            // BtnChange
            // 
            this.BtnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChange.Location = new System.Drawing.Point(7, 626);
            this.BtnChange.Margin = new System.Windows.Forms.Padding(4);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(147, 28);
            this.BtnChange.TabIndex = 28;
            this.BtnChange.Text = "Изменить фигуру";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCancel.Location = new System.Drawing.Point(7, 663);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(147, 28);
            this.BtnCancel.TabIndex = 29;
            this.BtnCancel.Text = "Снять выделение";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюПрограммыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 28);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюПрограммыToolStripMenuItem
            // 
            this.менюПрограммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьИзмененияToolStripMenuItem,
            this.вернутьИзмененияToolStripMenuItem,
            this.сохранитьИзображениеToolStripMenuItem,
            this.загрузитьИзображениеToolStripMenuItem,
            this.очиститьИщображениеToolStripMenuItem});
            this.менюПрограммыToolStripMenuItem.Name = "менюПрограммыToolStripMenuItem";
            this.менюПрограммыToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.менюПрограммыToolStripMenuItem.Text = "Меню программы";
            // 
            // отменитьИзмененияToolStripMenuItem
            // 
            this.отменитьИзмененияToolStripMenuItem.Name = "отменитьИзмененияToolStripMenuItem";
            this.отменитьИзмененияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.отменитьИзмененияToolStripMenuItem.Text = "Отменить изменения";
            this.отменитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.BtnCZ_Click);
            // 
            // вернутьИзмененияToolStripMenuItem
            // 
            this.вернутьИзмененияToolStripMenuItem.Name = "вернутьИзмененияToolStripMenuItem";
            this.вернутьИзмененияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.вернутьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.вернутьИзмененияToolStripMenuItem.Text = "Вернуть изменения";
            this.вернутьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.BtnCY_Click);
            // 
            // сохранитьИзображениеToolStripMenuItem
            // 
            this.сохранитьИзображениеToolStripMenuItem.Name = "сохранитьИзображениеToolStripMenuItem";
            this.сохранитьИзображениеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.сохранитьИзображениеToolStripMenuItem.Text = "Сохранить изображение";
            this.сохранитьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // загрузитьИзображениеToolStripMenuItem
            // 
            this.загрузитьИзображениеToolStripMenuItem.Name = "загрузитьИзображениеToolStripMenuItem";
            this.загрузитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.загрузитьИзображениеToolStripMenuItem.Text = "Загрузить изображение";
            this.загрузитьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // очиститьИщображениеToolStripMenuItem
            // 
            this.очиститьИщображениеToolStripMenuItem.Name = "очиститьИщображениеToolStripMenuItem";
            this.очиститьИщображениеToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.очиститьИщображениеToolStripMenuItem.Text = "Очистить изображение";
            this.очиститьИщображениеToolStripMenuItem.Click += new System.EventHandler(this.BtnClr_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "Цвет линии:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 398);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Список фигур:";
            // 
            // Form_Graphics_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1021, 696);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBPW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBY2);
            this.Controls.Add(this.TBX2);
            this.Controls.Add(this.TBY1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBX1);
            this.Controls.Add(this.List_Drawn_Figures);
            this.Controls.Add(this.PanCol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrackBar_Width);
            this.Controls.Add(this.GBShp);
            this.Controls.Add(this.pictureBox_Editor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Graphics_Editor";
            this.Text = "Lab1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Editor)).EndInit();
            this.GBShp.ResumeLayout(false);
            this.GBShp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Width)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Editor;
        private System.Windows.Forms.GroupBox GBShp;
        private System.Windows.Forms.RadioButton Ellipse;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Triangle;
        private System.Windows.Forms.TrackBar TrackBar_Width;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Hexagon;
        private System.Windows.Forms.RadioButton Octagon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanCol;
        private System.Windows.Forms.ComboBox List_Drawn_Figures;
        private System.Windows.Forms.TextBox TBX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBY1;
        private System.Windows.Forms.TextBox TBX2;
        private System.Windows.Forms.TextBox TBY2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBPW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзображениеToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem очиститьИщображениеToolStripMenuItem;
        private System.Windows.Forms.Label label9;
    }
}

