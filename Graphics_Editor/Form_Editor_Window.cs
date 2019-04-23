using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics_Editor
{
    public partial class Form_Editor_Window : Form
    {
        Bitmap pic;
        int x1, y1;

        public Form_Editor_Window()
        {
            InitializeComponent();
            pic = new Bitmap(1000, 1000);
            x1 = 0;
            y1 = 0;
        }

        private void pictureBox_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            Pen p;
            p = new Pen(Color.Black);
            Graphics g;
            g = Graphics.FromImage(pic);

            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(p, x1, y1, e.X, e.Y);
                pictureBox_Draw.Image = pic;
            }

            x1 = e.X;
            y1 = e.Y;
        }
    }
}
