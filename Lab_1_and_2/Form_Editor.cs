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
        private static Bitmap Bitmap_Current, Bitmap_Last;
        public PictureBox pictureBox;
        public Point[] point = new Point[0];
        private Shape shape;
        public static Color brushColor = Color.Black;
        public static int penWidth;
        private List<Shape> Figures_List = new List<Shape>();
        private Dictionary<string, Shape> figure = new Dictionary<string, Shape>();

        public Form_Editor()
        {
            figure.Add("Линия", new CLine());
            figure.Add("Круг", new CCircle());
            figure.Add("Эллипс", new CEllipse());
            figure.Add("Прямоугольник", new CRectangle());
            figure.Add("Квадрат", new CSquare());
            figure.Add("Треугольник", new CTriangle());
            InitializeComponent();
            pictureBox = Editor_Canvas;
            Bitmap_Current = new Bitmap(Editor_Canvas.Width, Editor_Canvas.Height);
            Bitmap_Last = new Bitmap(Editor_Canvas.Width, Editor_Canvas.Height);
        }

        private void Editor_Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            Array.Resize(ref point, point.Length + 1);
            point[point.Length - 1].X = e.X;
            point[point.Length - 1].Y = e.Y;
            Bitmap_Current = new Bitmap(Bitmap_Last);
            pictureBox.Image = Bitmap_Current;
        }

        private void Editor_Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (instrument.Text != "Треугольник")
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

            Bitmap_Last = new Bitmap(Bitmap_Current);

            // Создайм новый элемент
            figure.TryGetValue(instrument.Text, out shape);
            
            if (shape != null && point.Length > 1)
            {
                shape.Coords = point;
                shape.Draw(Bitmap_Last);
            }

            Editor_Canvas.Image = Bitmap_Last;
            if (point.Length > 1)
                Array.Resize(ref point, point.Length - 1);

            //в список нарисованную фигуру
            var newItem = shape;
            Figures_List.Add(newItem);
        }

        private void Color_Line_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                brushColor = colorDialog.Color;
            }
            Array.Resize(ref point, 0);
        }

        private void Changed_Width(object sender, EventArgs e)
        {
            penWidth = (int)width.Value;
            Bitmap_Last = new Bitmap(Editor_Canvas.Width, Editor_Canvas.Height);
            Array.Resize(ref point, 0);
        }
    }
}
