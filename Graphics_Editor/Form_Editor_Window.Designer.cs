namespace Graphics_Editor
{
    partial class Form_Editor_Window
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Panel_Pencil = new System.Windows.Forms.Panel();
            this.Panel_Triangle = new System.Windows.Forms.Panel();
            this.Panel_Circle = new System.Windows.Forms.Panel();
            this.Panel_Rectangle = new System.Windows.Forms.Panel();
            this.Panel_Square = new System.Windows.Forms.Panel();
            this.Panel_Line = new System.Windows.Forms.Panel();
            this.pictureBox_Draw = new System.Windows.Forms.PictureBox();
            this.Panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Draw)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.Color.SeaShell;
            this.Panel_Menu.Controls.Add(this.Panel_Pencil);
            this.Panel_Menu.Controls.Add(this.Panel_Triangle);
            this.Panel_Menu.Controls.Add(this.Panel_Circle);
            this.Panel_Menu.Controls.Add(this.Panel_Rectangle);
            this.Panel_Menu.Controls.Add(this.Panel_Square);
            this.Panel_Menu.Controls.Add(this.Panel_Line);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(1156, 110);
            this.Panel_Menu.TabIndex = 0;
            // 
            // Panel_Pencil
            // 
            this.Panel_Pencil.BackColor = System.Drawing.Color.Linen;
            this.Panel_Pencil.BackgroundImage = global::Graphics_Editor.Properties.Resources.pencil_clip_art;
            this.Panel_Pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_Pencil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Pencil.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Pencil.Location = new System.Drawing.Point(550, 0);
            this.Panel_Pencil.Name = "Panel_Pencil";
            this.Panel_Pencil.Size = new System.Drawing.Size(110, 110);
            this.Panel_Pencil.TabIndex = 5;
            // 
            // Panel_Triangle
            // 
            this.Panel_Triangle.BackColor = System.Drawing.Color.Linen;
            this.Panel_Triangle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Triangle.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Triangle.Location = new System.Drawing.Point(440, 0);
            this.Panel_Triangle.Name = "Panel_Triangle";
            this.Panel_Triangle.Size = new System.Drawing.Size(110, 110);
            this.Panel_Triangle.TabIndex = 4;
            // 
            // Panel_Circle
            // 
            this.Panel_Circle.BackColor = System.Drawing.Color.Linen;
            this.Panel_Circle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Circle.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Circle.Location = new System.Drawing.Point(330, 0);
            this.Panel_Circle.Name = "Panel_Circle";
            this.Panel_Circle.Size = new System.Drawing.Size(110, 110);
            this.Panel_Circle.TabIndex = 3;
            // 
            // Panel_Rectangle
            // 
            this.Panel_Rectangle.BackColor = System.Drawing.Color.Linen;
            this.Panel_Rectangle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Rectangle.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Rectangle.Location = new System.Drawing.Point(220, 0);
            this.Panel_Rectangle.Name = "Panel_Rectangle";
            this.Panel_Rectangle.Size = new System.Drawing.Size(110, 110);
            this.Panel_Rectangle.TabIndex = 2;
            // 
            // Panel_Square
            // 
            this.Panel_Square.BackColor = System.Drawing.Color.Linen;
            this.Panel_Square.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Square.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Square.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Square.Location = new System.Drawing.Point(110, 0);
            this.Panel_Square.Name = "Panel_Square";
            this.Panel_Square.Size = new System.Drawing.Size(110, 110);
            this.Panel_Square.TabIndex = 1;
            // 
            // Panel_Line
            // 
            this.Panel_Line.BackColor = System.Drawing.Color.Linen;
            this.Panel_Line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Line.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Line.Location = new System.Drawing.Point(0, 0);
            this.Panel_Line.Name = "Panel_Line";
            this.Panel_Line.Size = new System.Drawing.Size(110, 110);
            this.Panel_Line.TabIndex = 0;
            // 
            // pictureBox_Draw
            // 
            this.pictureBox_Draw.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox_Draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Draw.Location = new System.Drawing.Point(0, 110);
            this.pictureBox_Draw.Name = "pictureBox_Draw";
            this.pictureBox_Draw.Size = new System.Drawing.Size(1156, 541);
            this.pictureBox_Draw.TabIndex = 1;
            this.pictureBox_Draw.TabStop = false;
            this.pictureBox_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Draw_MouseMove);
            // 
            // Form_Editor_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 651);
            this.Controls.Add(this.pictureBox_Draw);
            this.Controls.Add(this.Panel_Menu);
            this.Name = "Form_Editor_Window";
            this.Text = "Form1";
            this.Panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Draw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Panel Panel_Triangle;
        private System.Windows.Forms.Panel Panel_Circle;
        private System.Windows.Forms.Panel Panel_Rectangle;
        private System.Windows.Forms.Panel Panel_Square;
        private System.Windows.Forms.Panel Panel_Line;
        private System.Windows.Forms.PictureBox pictureBox_Draw;
        private System.Windows.Forms.Panel Panel_Pencil;
    }
}

