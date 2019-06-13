namespace GraphicsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonRETURN = new System.Windows.Forms.Button();
            this.buttonUNDO = new System.Windows.Forms.Button();
            this.cbShift = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbbShapes = new System.Windows.Forms.ComboBox();
            this.tbColor = new System.Windows.Forms.Button();
            this.tbPenWidth = new System.Windows.Forms.TextBox();
            this.lblPenW = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TextBox();
            this.tbW = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lbFigures = new System.Windows.Forms.ListBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1450, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.buttonColor);
            this.panel1.Controls.Add(this.buttonRETURN);
            this.panel1.Controls.Add(this.buttonUNDO);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 660);
            this.panel1.TabIndex = 1;
            // 
            // buttonColor
            // 
            this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonColor.Location = new System.Drawing.Point(4, 221);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(101, 33);
            this.buttonColor.TabIndex = 26;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonRETURN
            // 
            this.buttonRETURN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRETURN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRETURN.Image = ((System.Drawing.Image)(resources.GetObject("buttonRETURN.Image")));
            this.buttonRETURN.Location = new System.Drawing.Point(56, 601);
            this.buttonRETURN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRETURN.Name = "buttonRETURN";
            this.buttonRETURN.Size = new System.Drawing.Size(49, 46);
            this.buttonRETURN.TabIndex = 25;
            this.buttonRETURN.UseVisualStyleBackColor = false;
            this.buttonRETURN.Click += new System.EventHandler(this.buttonRETURN_Click);
            // 
            // buttonUNDO
            // 
            this.buttonUNDO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUNDO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUNDO.Image = ((System.Drawing.Image)(resources.GetObject("buttonUNDO.Image")));
            this.buttonUNDO.Location = new System.Drawing.Point(4, 601);
            this.buttonUNDO.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUNDO.Name = "buttonUNDO";
            this.buttonUNDO.Size = new System.Drawing.Size(49, 46);
            this.buttonUNDO.TabIndex = 24;
            this.buttonUNDO.UseVisualStyleBackColor = false;
            this.buttonUNDO.Click += new System.EventHandler(this.buttonUNDO_Click);
            // 
            // cbShift
            // 
            this.cbShift.AutoSize = true;
            this.cbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShift.ForeColor = System.Drawing.Color.White;
            this.cbShift.Location = new System.Drawing.Point(115, 656);
            this.cbShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(63, 21);
            this.cbShift.TabIndex = 20;
            this.cbShift.Text = "Shift";
            this.cbShift.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(4, 295);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(101, 56);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Value = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(4, 120);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 94);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(108, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1036, 660);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.tbColor);
            this.panel2.Controls.Add(this.tbPenWidth);
            this.panel2.Controls.Add(this.lblPenW);
            this.panel2.Controls.Add(this.lblCol);
            this.panel2.Controls.Add(this.lblH);
            this.panel2.Controls.Add(this.lblW);
            this.panel2.Controls.Add(this.lblY);
            this.panel2.Controls.Add(this.lblX);
            this.panel2.Controls.Add(this.tbH);
            this.panel2.Controls.Add(this.tbW);
            this.panel2.Controls.Add(this.tbY);
            this.panel2.Controls.Add(this.tbX);
            this.panel2.Controls.Add(this.lbFigures);
            this.panel2.Controls.Add(this.btnChange);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1144, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 660);
            this.panel2.TabIndex = 3;
            // 
            // cmbbShapes
            // 
            this.cmbbShapes.FormattingEnabled = true;
            this.cmbbShapes.Location = new System.Drawing.Point(4, 79);
            this.cmbbShapes.Name = "cmbbShapes";
            this.cmbbShapes.Size = new System.Drawing.Size(101, 24);
            this.cmbbShapes.TabIndex = 43;
            // 
            // tbColor
            // 
            this.tbColor.BackColor = System.Drawing.SystemColors.Info;
            this.tbColor.Location = new System.Drawing.Point(220, 130);
            this.tbColor.Margin = new System.Windows.Forms.Padding(4);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(62, 25);
            this.tbColor.TabIndex = 42;
            this.tbColor.UseVisualStyleBackColor = false;
            this.tbColor.Click += new System.EventHandler(this.tbColor_Click);
            // 
            // tbPenWidth
            // 
            this.tbPenWidth.Location = new System.Drawing.Point(75, 131);
            this.tbPenWidth.Margin = new System.Windows.Forms.Padding(4);
            this.tbPenWidth.Name = "tbPenWidth";
            this.tbPenWidth.Size = new System.Drawing.Size(64, 22);
            this.tbPenWidth.TabIndex = 35;
            // 
            // lblPenW
            // 
            this.lblPenW.AutoSize = true;
            this.lblPenW.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPenW.Location = new System.Drawing.Point(19, 125);
            this.lblPenW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPenW.Name = "lblPenW";
            this.lblPenW.Size = new System.Drawing.Size(44, 34);
            this.lblPenW.TabIndex = 41;
            this.lblPenW.Text = "Pen\r\nwidth:";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCol.Location = new System.Drawing.Point(163, 134);
            this.lblCol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(45, 17);
            this.lblCol.TabIndex = 40;
            this.lblCol.Text = "Color:";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblH.Location = new System.Drawing.Point(163, 79);
            this.lblH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(53, 17);
            this.lblH.TabIndex = 39;
            this.lblH.Text = "Height:";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblW.Location = new System.Drawing.Point(19, 77);
            this.lblW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(48, 17);
            this.lblW.TabIndex = 38;
            this.lblW.Text = "Width:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblY.Location = new System.Drawing.Point(163, 25);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(21, 17);
            this.lblY.TabIndex = 37;
            this.lblY.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblX.Location = new System.Drawing.Point(19, 26);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 17);
            this.lblX.TabIndex = 36;
            this.lblX.Text = "X:";
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(220, 74);
            this.tbH.Margin = new System.Windows.Forms.Padding(4);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(62, 22);
            this.tbH.TabIndex = 34;
            // 
            // tbW
            // 
            this.tbW.Location = new System.Drawing.Point(75, 73);
            this.tbW.Margin = new System.Windows.Forms.Padding(4);
            this.tbW.Name = "tbW";
            this.tbW.Size = new System.Drawing.Size(64, 22);
            this.tbW.TabIndex = 33;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(220, 21);
            this.tbY.Margin = new System.Windows.Forms.Padding(4);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(62, 22);
            this.tbY.TabIndex = 32;
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(75, 22);
            this.tbX.Margin = new System.Windows.Forms.Padding(4);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(64, 22);
            this.tbX.TabIndex = 31;
            // 
            // lbFigures
            // 
            this.lbFigures.FormattingEnabled = true;
            this.lbFigures.ItemHeight = 16;
            this.lbFigures.Location = new System.Drawing.Point(22, 341);
            this.lbFigures.Margin = new System.Windows.Forms.Padding(4);
            this.lbFigures.Name = "lbFigures";
            this.lbFigures.Size = new System.Drawing.Size(260, 212);
            this.lbFigures.TabIndex = 30;
            this.lbFigures.SelectedIndexChanged += new System.EventHandler(this.lbFigures_SelectedIndexChanged);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.Location = new System.Drawing.Point(22, 199);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(260, 37);
            this.btnChange.TabIndex = 29;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 688);
            this.Controls.Add(this.cmbbShapes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbShift);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Graphics Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cbShift;
        private System.Windows.Forms.Button buttonRETURN;
        private System.Windows.Forms.Button buttonUNDO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tbColor;
        private System.Windows.Forms.TextBox tbPenWidth;
        private System.Windows.Forms.Label lblPenW;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.TextBox tbW;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.ListBox lbFigures;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cmbbShapes;
        private System.Windows.Forms.Button buttonColor;
    }
}

