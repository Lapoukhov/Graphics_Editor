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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBShp = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RBHex = new System.Windows.Forms.RadioButton();
            this.RBOct = new System.Windows.Forms.RadioButton();
            this.RBElp = new System.Windows.Forms.RadioButton();
            this.RBRec = new System.Windows.Forms.RadioButton();
            this.RBLine = new System.Windows.Forms.RadioButton();
            this.RBTri = new System.Windows.Forms.RadioButton();
            this.TrWidth = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.PanCol = new System.Windows.Forms.Panel();
            this.BtnClr = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBShp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrWidth)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(156, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 572);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // GBShp
            // 
            this.GBShp.Controls.Add(this.label1);
            this.GBShp.Controls.Add(this.RBHex);
            this.GBShp.Controls.Add(this.RBOct);
            this.GBShp.Controls.Add(this.RBElp);
            this.GBShp.Controls.Add(this.RBRec);
            this.GBShp.Controls.Add(this.RBLine);
            this.GBShp.Controls.Add(this.RBTri);
            this.GBShp.Location = new System.Drawing.Point(16, 37);
            this.GBShp.Margin = new System.Windows.Forms.Padding(4);
            this.GBShp.Name = "GBShp";
            this.GBShp.Padding = new System.Windows.Forms.Padding(4);
            this.GBShp.Size = new System.Drawing.Size(132, 208);
            this.GBShp.TabIndex = 5;
            this.GBShp.TabStop = false;
            this.GBShp.Text = "Shapes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Width";
            // 
            // RBHex
            // 
            this.RBHex.AutoSize = true;
            this.RBHex.Location = new System.Drawing.Point(8, 164);
            this.RBHex.Margin = new System.Windows.Forms.Padding(4);
            this.RBHex.Name = "RBHex";
            this.RBHex.Size = new System.Drawing.Size(85, 21);
            this.RBHex.TabIndex = 11;
            this.RBHex.TabStop = true;
            this.RBHex.Text = "Hexagon";
            this.RBHex.UseVisualStyleBackColor = true;
            // 
            // RBOct
            // 
            this.RBOct.AutoSize = true;
            this.RBOct.Location = new System.Drawing.Point(8, 135);
            this.RBOct.Margin = new System.Windows.Forms.Padding(4);
            this.RBOct.Name = "RBOct";
            this.RBOct.Size = new System.Drawing.Size(83, 21);
            this.RBOct.TabIndex = 10;
            this.RBOct.TabStop = true;
            this.RBOct.Text = "Octagon";
            this.RBOct.UseVisualStyleBackColor = true;
            // 
            // RBElp
            // 
            this.RBElp.AutoSize = true;
            this.RBElp.Location = new System.Drawing.Point(8, 79);
            this.RBElp.Margin = new System.Windows.Forms.Padding(4);
            this.RBElp.Name = "RBElp";
            this.RBElp.Size = new System.Drawing.Size(70, 21);
            this.RBElp.TabIndex = 9;
            this.RBElp.TabStop = true;
            this.RBElp.Text = "Ellipse";
            this.RBElp.UseVisualStyleBackColor = true;
            // 
            // RBRec
            // 
            this.RBRec.AutoSize = true;
            this.RBRec.Location = new System.Drawing.Point(8, 52);
            this.RBRec.Margin = new System.Windows.Forms.Padding(4);
            this.RBRec.Name = "RBRec";
            this.RBRec.Size = new System.Drawing.Size(93, 21);
            this.RBRec.TabIndex = 8;
            this.RBRec.TabStop = true;
            this.RBRec.Text = "Rectangle";
            this.RBRec.UseVisualStyleBackColor = true;
            // 
            // RBLine
            // 
            this.RBLine.AutoSize = true;
            this.RBLine.Location = new System.Drawing.Point(8, 23);
            this.RBLine.Margin = new System.Windows.Forms.Padding(4);
            this.RBLine.Name = "RBLine";
            this.RBLine.Size = new System.Drawing.Size(56, 21);
            this.RBLine.TabIndex = 7;
            this.RBLine.TabStop = true;
            this.RBLine.Text = "Line";
            this.RBLine.UseVisualStyleBackColor = true;
            // 
            // RBTri
            // 
            this.RBTri.AutoSize = true;
            this.RBTri.Location = new System.Drawing.Point(8, 107);
            this.RBTri.Margin = new System.Windows.Forms.Padding(4);
            this.RBTri.Name = "RBTri";
            this.RBTri.Size = new System.Drawing.Size(81, 21);
            this.RBTri.TabIndex = 6;
            this.RBTri.TabStop = true;
            this.RBTri.Text = "Triangle";
            this.RBTri.UseVisualStyleBackColor = true;
            // 
            // TrWidth
            // 
            this.TrWidth.Location = new System.Drawing.Point(16, 264);
            this.TrWidth.Margin = new System.Windows.Forms.Padding(4);
            this.TrWidth.Name = "TrWidth";
            this.TrWidth.Size = new System.Drawing.Size(132, 56);
            this.TrWidth.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Width";
            // 
            // PanCol
            // 
            this.PanCol.BackColor = System.Drawing.Color.Black;
            this.PanCol.Location = new System.Drawing.Point(16, 316);
            this.PanCol.Margin = new System.Windows.Forms.Padding(4);
            this.PanCol.Name = "PanCol";
            this.PanCol.Size = new System.Drawing.Size(132, 21);
            this.PanCol.TabIndex = 15;
            this.PanCol.Click += new System.EventHandler(this.PanCol_Click);
            // 
            // BtnClr
            // 
            this.BtnClr.Location = new System.Drawing.Point(16, 380);
            this.BtnClr.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClr.Name = "BtnClr";
            this.BtnClr.Size = new System.Drawing.Size(132, 28);
            this.BtnClr.TabIndex = 16;
            this.BtnClr.Text = "Clear";
            this.BtnClr.UseVisualStyleBackColor = true;
            this.BtnClr.Click += new System.EventHandler(this.BtnClr_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 416);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TBX1
            // 
            this.TBX1.Location = new System.Drawing.Point(1110, 38);
            this.TBX1.Margin = new System.Windows.Forms.Padding(4);
            this.TBX1.Name = "TBX1";
            this.TBX1.Size = new System.Drawing.Size(84, 22);
            this.TBX1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1013, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "X1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1013, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Y1";
            // 
            // TBY1
            // 
            this.TBY1.Location = new System.Drawing.Point(1110, 77);
            this.TBY1.Margin = new System.Windows.Forms.Padding(4);
            this.TBY1.Name = "TBY1";
            this.TBY1.Size = new System.Drawing.Size(84, 22);
            this.TBY1.TabIndex = 21;
            // 
            // TBX2
            // 
            this.TBX2.Location = new System.Drawing.Point(1110, 115);
            this.TBX2.Margin = new System.Windows.Forms.Padding(4);
            this.TBX2.Name = "TBX2";
            this.TBX2.Size = new System.Drawing.Size(84, 22);
            this.TBX2.TabIndex = 22;
            // 
            // TBY2
            // 
            this.TBY2.Location = new System.Drawing.Point(1110, 152);
            this.TBY2.Margin = new System.Windows.Forms.Padding(4);
            this.TBY2.Name = "TBY2";
            this.TBY2.Size = new System.Drawing.Size(84, 22);
            this.TBY2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1013, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "X2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1013, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Y2";
            // 
            // TBPW
            // 
            this.TBPW.Location = new System.Drawing.Point(1110, 184);
            this.TBPW.Margin = new System.Windows.Forms.Padding(4);
            this.TBPW.Name = "TBPW";
            this.TBPW.Size = new System.Drawing.Size(84, 22);
            this.TBPW.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1013, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Pen width";
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(1093, 217);
            this.BtnChange.Margin = new System.Windows.Forms.Padding(4);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(103, 28);
            this.BtnChange.TabIndex = 28;
            this.BtnChange.Text = "Применить";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(1093, 253);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(103, 28);
            this.BtnCancel.TabIndex = 29;
            this.BtnCancel.Text = "Отмена";
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
            this.menuStrip1.Size = new System.Drawing.Size(1207, 28);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюПрограммыToolStripMenuItem
            // 
            this.менюПрограммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьИзмененияToolStripMenuItem,
            this.вернутьИзмененияToolStripMenuItem,
            this.сохранитьИзображениеToolStripMenuItem,
            this.загрузитьИзображениеToolStripMenuItem});
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
            // Form_Graphics_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1207, 614);
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnClr);
            this.Controls.Add(this.PanCol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrWidth);
            this.Controls.Add(this.GBShp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Graphics_Editor";
            this.Text = "Lab1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBShp.ResumeLayout(false);
            this.GBShp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrWidth)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GBShp;
        private System.Windows.Forms.RadioButton RBElp;
        private System.Windows.Forms.RadioButton RBRec;
        private System.Windows.Forms.RadioButton RBLine;
        private System.Windows.Forms.RadioButton RBTri;
        private System.Windows.Forms.TrackBar TrWidth;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBHex;
        private System.Windows.Forms.RadioButton RBOct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanCol;
        private System.Windows.Forms.Button BtnClr;
        private System.Windows.Forms.ComboBox comboBox1;
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
    }
}

