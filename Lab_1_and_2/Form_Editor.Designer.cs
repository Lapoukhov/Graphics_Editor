namespace Lab_1_and_2
{
    partial class Form_Editor
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
            this.Editor_Canvas = new System.Windows.Forms.PictureBox();
            this.instrument = new System.Windows.Forms.ComboBox();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.colour = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label_Figure = new System.Windows.Forms.Label();
            this.label_LIne = new System.Windows.Forms.Label();
            this.label_Color = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Editor_Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Editor_Canvas
            // 
            this.Editor_Canvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editor_Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Editor_Canvas.Location = new System.Drawing.Point(199, 40);
            this.Editor_Canvas.Margin = new System.Windows.Forms.Padding(4);
            this.Editor_Canvas.Name = "Editor_Canvas";
            this.Editor_Canvas.Size = new System.Drawing.Size(878, 517);
            this.Editor_Canvas.TabIndex = 0;
            this.Editor_Canvas.TabStop = false;
            this.Editor_Canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Editor_Canvas_MouseClick);
            this.Editor_Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Editor_Canvas_MouseMove);
            // 
            // instrument
            // 
            this.instrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.instrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instrument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.instrument.FormattingEnabled = true;
            this.instrument.Items.AddRange(new object[] {
            "Линия",
            "Круг",
            "Эллипс",
            "Прямоугольник",
            "Квадрат",
            "Треугольник"});
            this.instrument.Location = new System.Drawing.Point(16, 72);
            this.instrument.Margin = new System.Windows.Forms.Padding(4);
            this.instrument.Name = "instrument";
            this.instrument.Size = new System.Drawing.Size(160, 26);
            this.instrument.TabIndex = 1;
            this.instrument.Text = "Линия";
            // 
            // width
            // 
            this.width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.width.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.width.Location = new System.Drawing.Point(106, 185);
            this.width.Margin = new System.Windows.Forms.Padding(4);
            this.width.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(70, 24);
            this.width.TabIndex = 3;
            this.width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width.ValueChanged += new System.EventHandler(this.Changed_Width);
            // 
            // colour
            // 
            this.colour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colour.Location = new System.Drawing.Point(16, 301);
            this.colour.Margin = new System.Windows.Forms.Padding(4);
            this.colour.Name = "colour";
            this.colour.Size = new System.Drawing.Size(160, 34);
            this.colour.TabIndex = 4;
            this.colour.Text = "Выбрать";
            this.colour.UseVisualStyleBackColor = false;
            this.colour.Click += new System.EventHandler(this.Color_Line_Click);
            // 
            // label_Figure
            // 
            this.label_Figure.AutoSize = true;
            this.label_Figure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Figure.Location = new System.Drawing.Point(13, 40);
            this.label_Figure.Name = "label_Figure";
            this.label_Figure.Size = new System.Drawing.Size(116, 18);
            this.label_Figure.TabIndex = 5;
            this.label_Figure.Text = "Выбор фигуры:";
            // 
            // label_LIne
            // 
            this.label_LIne.AutoSize = true;
            this.label_LIne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LIne.Location = new System.Drawing.Point(13, 187);
            this.label_LIne.Name = "label_LIne";
            this.label_LIne.Size = new System.Drawing.Size(74, 18);
            this.label_LIne.TabIndex = 6;
            this.label_LIne.Text = "Толщина:";
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Color.Location = new System.Drawing.Point(13, 265);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(91, 18);
            this.label_Color.TabIndex = 7;
            this.label_Color.Text = "Цвет линии:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюПрограммыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1090, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюПрограммыToolStripMenuItem
            // 
            this.менюПрограммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьИзмененияToolStripMenuItem,
            this.вернутьИзмененияToolStripMenuItem,
            this.сохранитьИзображениеToolStripMenuItem});
            this.менюПрограммыToolStripMenuItem.Name = "менюПрограммыToolStripMenuItem";
            this.менюПрограммыToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.менюПрограммыToolStripMenuItem.Text = "Меню программы";
            // 
            // отменитьИзмененияToolStripMenuItem
            // 
            this.отменитьИзмененияToolStripMenuItem.Name = "отменитьИзмененияToolStripMenuItem";
            this.отменитьИзмененияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.отменитьИзмененияToolStripMenuItem.Text = "Отменить изменения";
            this.отменитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.Cancel_ToolStripMenuItem_Click);
            // 
            // вернутьИзмененияToolStripMenuItem
            // 
            this.вернутьИзмененияToolStripMenuItem.Name = "вернутьИзмененияToolStripMenuItem";
            this.вернутьИзмененияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.вернутьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.вернутьИзмененияToolStripMenuItem.Text = "Вернуть изменения";
            this.вернутьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.Return_ToolStripMenuItem_Click);
            // 
            // сохранитьИзображениеToolStripMenuItem
            // 
            this.сохранитьИзображениеToolStripMenuItem.Name = "сохранитьИзображениеToolStripMenuItem";
            this.сохранитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.сохранитьИзображениеToolStripMenuItem.Text = "Сохранить изображение";
            // 
            // Form_Editor
            // 
            this.AcceptButton = this.colour;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1090, 570);
            this.Controls.Add(this.label_Color);
            this.Controls.Add(this.label_LIne);
            this.Controls.Add(this.label_Figure);
            this.Controls.Add(this.colour);
            this.Controls.Add(this.width);
            this.Controls.Add(this.instrument);
            this.Controls.Add(this.Editor_Canvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Editor";
            this.Text = "Form_Editor";
            ((System.ComponentModel.ISupportInitialize)(this.Editor_Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Editor_Canvas;
        private System.Windows.Forms.ComboBox instrument;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.Button colour;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label_Figure;
        private System.Windows.Forms.Label label_LIne;
        private System.Windows.Forms.Label label_Color;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзображениеToolStripMenuItem;
    }
}

