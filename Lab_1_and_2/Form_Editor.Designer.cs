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
            this.redactor = new System.Windows.Forms.PictureBox();
            this.instrument = new System.Windows.Forms.ComboBox();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.colour = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label_Figure = new System.Windows.Forms.Label();
            this.label_LIne = new System.Windows.Forms.Label();
            this.label_Color = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            this.SuspendLayout();
            // 
            // redactor
            // 
            this.redactor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.redactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redactor.Location = new System.Drawing.Point(199, 15);
            this.redactor.Margin = new System.Windows.Forms.Padding(4);
            this.redactor.Name = "redactor";
            this.redactor.Size = new System.Drawing.Size(878, 541);
            this.redactor.TabIndex = 0;
            this.redactor.TabStop = false;
            this.redactor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.redactor_MouseClick);
            this.redactor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.redactor_MouseMove);
            // 
            // instrument
            // 
            this.instrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.instrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instrument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.instrument.FormattingEnabled = true;
            this.instrument.Items.AddRange(new object[] {
            "line",
            "rectangle",
            "square",
            "triangle",
            "circle",
            "ellipse"});
            this.instrument.Location = new System.Drawing.Point(16, 47);
            this.instrument.Margin = new System.Windows.Forms.Padding(4);
            this.instrument.Name = "instrument";
            this.instrument.Size = new System.Drawing.Size(160, 26);
            this.instrument.TabIndex = 1;
            this.instrument.Text = "line";
            // 
            // width
            // 
            this.width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.width.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.width.Location = new System.Drawing.Point(16, 162);
            this.width.Margin = new System.Windows.Forms.Padding(4);
            this.width.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(160, 24);
            this.width.TabIndex = 3;
            this.width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            // 
            // colour
            // 
            this.colour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colour.Location = new System.Drawing.Point(16, 276);
            this.colour.Margin = new System.Windows.Forms.Padding(4);
            this.colour.Name = "colour";
            this.colour.Size = new System.Drawing.Size(160, 34);
            this.colour.TabIndex = 4;
            this.colour.Text = "colour";
            this.colour.UseVisualStyleBackColor = false;
            this.colour.Click += new System.EventHandler(this.color_Click);
            // 
            // label_Figure
            // 
            this.label_Figure.AutoSize = true;
            this.label_Figure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Figure.Location = new System.Drawing.Point(13, 15);
            this.label_Figure.Name = "label_Figure";
            this.label_Figure.Size = new System.Drawing.Size(116, 18);
            this.label_Figure.TabIndex = 5;
            this.label_Figure.Text = "Выбор фигуры:";
            // 
            // label_LIne
            // 
            this.label_LIne.AutoSize = true;
            this.label_LIne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LIne.Location = new System.Drawing.Point(13, 129);
            this.label_LIne.Name = "label_LIne";
            this.label_LIne.Size = new System.Drawing.Size(119, 18);
            this.label_LIne.TabIndex = 6;
            this.label_LIne.Text = "Толщина линии:";
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Color.Location = new System.Drawing.Point(13, 240);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(91, 18);
            this.label_Color.TabIndex = 7;
            this.label_Color.Text = "Цвет линии:";
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
            this.Controls.Add(this.redactor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Editor";
            this.Text = "Form_Editor";
            ((System.ComponentModel.ISupportInitialize)(this.redactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redactor;
        private System.Windows.Forms.ComboBox instrument;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.Button colour;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label_Figure;
        private System.Windows.Forms.Label label_LIne;
        private System.Windows.Forms.Label label_Color;
    }
}

