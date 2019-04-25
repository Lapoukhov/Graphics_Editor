using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_and_2
{
    public partial class Form_Editor : Form
    {
        public Point[] point = new Point[0];
        private Shape shape;
        private static Bitmap BitmapMain, BitmapBuff;
        public PictureBox pictureBox;
        public static int penWidth;
        public static Color brushColor = Color.Black;
        private Dictionary<string, Shape> instr = new Dictionary<string, Shape>();
        private List<Shape> allFigs = new List<Shape>();

        public Form_Editor()
        {
            instr.Add("line", new CLine());
            instr.Add("rectangle", new CRectangle());
            instr.Add("square", new CSquare());
            instr.Add("triangle", new CTriangle());
            instr.Add("circle", new CCircle());
            instr.Add("ellipse", new CEllipse());
            InitializeComponent();
            pictureBox = redactor;
            BitmapMain = new Bitmap(redactor.Width, redactor.Height);
            BitmapBuff = new Bitmap(redactor.Width, redactor.Height);
        }

        private void redactor_MouseClick(object sender, MouseEventArgs e)
        {
            Array.Resize(ref point, point.Length + 1);
            point[point.Length - 1].X = e.X;
            point[point.Length - 1].Y = e.Y;
            BitmapMain = new Bitmap(BitmapBuff);
            pictureBox.Image = BitmapMain;
        }

        private void redactor_MouseMove(object sender, MouseEventArgs e)
        {
            if (instrument.Text != "triangle")
            {
                if (point.Length > 1)
                {
                    Array.Resize(ref point, 0);
                }
            }
            else
            {
                if (point.Length > 2)
                {
                    Array.Resize(ref point, 0);
                }
            }

            if (point.Length > 0)
            {
                Array.Resize(ref point, point.Length + 1);
                point[point.Length - 1].X = e.X;
                point[point.Length - 1].Y = e.Y;
            }

            BitmapBuff = new Bitmap(BitmapMain);

            // Создайм новый элемент
            instr.TryGetValue(instrument.Text, out shape);
            
            if (shape != null && point.Length > 1)
            {
                shape.Coords = point;
                shape.Draw(BitmapBuff);
            }

            redactor.Image = BitmapBuff;
            if (point.Length > 1)
                Array.Resize(ref point, point.Length - 1);

            //добавляем отрисованную фигуру в лист
            var newItem = shape;
            allFigs.Add(newItem);
        }

        private void color_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                brushColor = colorDialog.Color;
            }
            Array.Resize(ref point, 0);
        }

        private void width_ValueChanged(object sender, EventArgs e)
        {
            penWidth = (int)width.Value;
            BitmapBuff = new Bitmap(redactor.Width, redactor.Height);
            Array.Resize(ref point, 0);
        }
    }
}
