﻿using System;
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

        private Stack<Bitmap> Cancel_Stack = new Stack<Bitmap>();
        private Stack<Bitmap> Redo_Stack = new Stack<Bitmap>();

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

            var copy = Bitmap_Last.Clone(new Rectangle(0, 0, Bitmap_Last.Width, Bitmap_Last.Height), Bitmap_Last.PixelFormat);
            Cancel_Stack.Push(copy);
            Redo_Stack.Push(copy);

            Bitmap_Current = new Bitmap(Bitmap_Last);
            pictureBox.Image = Bitmap_Current;
        }

        private void Editor_Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (figure_Form.Text != "Треугольник")
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
            figure.TryGetValue(figure_Form.Text, out shape);
            
            if (shape != null && point.Length > 1)
            {
                shape.Coords = point;
                shape.Draw(Bitmap_Last);
            }

            Editor_Canvas.Image = Bitmap_Last;
            if (point.Length > 1)
                Array.Resize(ref point, point.Length - 1);

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

        private void Cancel_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            if (Cancel_Stack.Count > 0)
            {
                if (i == 1)
                {
                    Bitmap_Current = Cancel_Stack.Pop();
                    var Copy_Redo = Bitmap_Current.Clone(new Rectangle(0, 0, Bitmap_Current.Width, Bitmap_Current.Height), Bitmap_Current.PixelFormat);
                    Redo_Stack.Push(Copy_Redo);
                    i++;
                }
                else
                {
                    Bitmap_Current = Cancel_Stack.Pop();
                }
                if (Cancel_Stack.Count > 0)
                {
                    Bitmap_Current = Cancel_Stack.Pop();
                    var copyRedo = Bitmap_Current.Clone(new Rectangle(0, 0, Bitmap_Current.Width, Bitmap_Current.Height), Bitmap_Current.PixelFormat);
                    Redo_Stack.Push(copyRedo);
                    pictureBox.Image = Bitmap_Current;
                }
            }
        }

        private void Return_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            if (Redo_Stack.Count > 0)
            {
                if (i == 1)
                {
                    Bitmap_Current = Redo_Stack.Pop();
                    var Copy = Bitmap_Current.Clone(new Rectangle(0, 0, Bitmap_Current.Width, Bitmap_Current.Height), Bitmap_Current.PixelFormat);
                    Cancel_Stack.Push(Copy);
                    i++;
                }
                else
                {
                    Bitmap_Current = Cancel_Stack.Pop();
                }
                if (Redo_Stack.Count > 0)
                {
                    Bitmap_Current = Redo_Stack.Pop();
                    var copy = Bitmap_Current.Clone(new Rectangle(0, 0, Bitmap_Current.Width, Bitmap_Current.Height), Bitmap_Current.PixelFormat);
                    Cancel_Stack.Push(copy);
                    pictureBox.Image = Bitmap_Current;
                }
            }
        }

        private void Changed_Width(object sender, EventArgs e)
        {
            penWidth = (int)width.Value;
            Bitmap_Last = new Bitmap(Editor_Canvas.Width, Editor_Canvas.Height);
            Array.Resize(ref point, 0);
        }
    }
}
