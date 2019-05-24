using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace _1laba
{
    public partial class Form_Graphics_Editor : Form
    {
        List<Shape> shapes = new List<Shape>();
        List<Shape> shapesRes = new List<Shape>();
        List<Type> typeList = new List<Type>();
        Type[] arrList;
        bool MousePressed = false;
        int NCleared = 0;
        bool WasCYed = false;
        Color CurrColor = Color.Black;
        Shape CurrShape, ChoosenShape;
        LineCreator LineC = new LineCreator();
        RecCreator RecC = new RecCreator();
        ElpCreator ElpC = new ElpCreator();
        TriCreator TriC = new TriCreator();
        OctCreator OctC = new OctCreator();
        HexCreator HexC = new HexCreator();

        public Form_Graphics_Editor()
        {
            InitializeComponent();
            CurrShape = new Line();
            typeList.Add(CurrShape.GetType());
            CurrShape = new Rec();
            typeList.Add(CurrShape.GetType());
            CurrShape = new Elp();
            typeList.Add(CurrShape.GetType());
            CurrShape = new Tri();
            typeList.Add(CurrShape.GetType());
            CurrShape = new Oct();
            typeList.Add(CurrShape.GetType());
            CurrShape = new Hex();
            typeList.Add(CurrShape.GetType());
            arrList = typeList.ToArray<Type>();
        }

        public void Reload()
        {
            List_Drawn_Figures.Items.Clear();
            foreach (Shape item in shapes)
            {
                List_Drawn_Figures.Items.Add(item);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
            if (MousePressed)
                CurrShape.Draw(e.Graphics);
            if (SelectedShape.IsSelected())
            {
                Pen P = new Pen(Color.Red);
                e.Graphics.DrawRectangle(P, SelectedShape.GetX()-1, SelectedShape.GetY()-1, SelectedShape.GetW()+2, SelectedShape.GetH()+2);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MousePressed = true;
            if (Line.Checked)
            {
                CurrShape = LineC.Create(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y, new Pen(CurrColor, TrackBar_Width.Value));
            }
            else if (Rectangle.Checked)
            {
                CurrShape = RecC.Create(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y, new Pen(CurrColor, TrackBar_Width.Value));
            }
            else if (Ellipse.Checked)
            {
                CurrShape = ElpC.Create(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y, new Pen(CurrColor, TrackBar_Width.Value));
            }
            else if (Triangle.Checked)
            {
                CurrShape = TriC.Create(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y, new Pen(CurrColor, TrackBar_Width.Value));
            }
            else if (Octagon.Checked)
            {
                CurrShape = OctC.Create(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y, new Pen(CurrColor, TrackBar_Width.Value));
            }
            else if (Hexagon.Checked)
            {
                CurrShape = HexC.Create(e.Location.X, e.Location.Y, e.Location.X, e.Location.Y, new Pen(CurrColor, TrackBar_Width.Value));
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MousePressed)
            {
                CurrShape.X2 = e.Location.X;
                CurrShape.Y2 = e.Location.Y;
            }
            pictureBox_Editor.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            shapes.Add(CurrShape);
            Reload();
            MousePressed = false;
            NCleared = 0;
            if (WasCYed)
            {
                WasCYed = false;
                shapesRes.Clear();
            }
        }

        private void BtnCZ_Click(object sender, EventArgs e)
        {
            if (shapes.Count > 0)
            {
                shapesRes.Add(shapes[shapes.Count - 1]);
                shapes.RemoveAt(shapes.Count - 1);
                pictureBox_Editor.Refresh();
                WasCYed = true;
            }
            if (NCleared != 0)
            {
                int SC = shapesRes.Count;
                for (int i = SC - 1; i >= SC - NCleared; i--)
                {
                    shapes.Add(shapesRes[i]);
                    shapesRes.RemoveAt(i);
                }
                pictureBox_Editor.Refresh();
                NCleared = 0;
            }
            Reload();
        }

        private void BtnCY_Click(object sender, EventArgs e)
        {
            if (shapesRes.Count > 0)
            {
                shapes.Add(shapesRes[shapesRes.Count - 1]);
                shapesRes.RemoveAt(shapesRes.Count - 1);
                pictureBox_Editor.Refresh();
            }
            Reload();
        }

        private void BtnClr_Click(object sender, EventArgs e)
        {
            NCleared = shapes.Count;
            for (int i = NCleared - 1; i >= 0; i--)
            {
                shapesRes.Add(shapes[i]);
                shapes.RemoveAt(i);
            }
            Reload();
            pictureBox_Editor.Refresh();
        }

        private void PanCol_Click(object sender, EventArgs e)
        {
            ColorDialog Di = new ColorDialog();
            Di.AllowFullOpen = true;
            if (Di.ShowDialog() == DialogResult.OK)
            {
                CurrColor = Di.Color;
                PanCol.BackColor = CurrColor;
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {

            if (shapes[List_Drawn_Figures.SelectedIndex] is IEditable)
            {
                shapes[List_Drawn_Figures.SelectedIndex].PC = PanCol.BackColor.ToArgb();
                shapes[List_Drawn_Figures.SelectedIndex].PW = Convert.ToInt32(TBPW.Text);
                shapes[List_Drawn_Figures.SelectedIndex].X1 = Convert.ToInt32(TBX1.Text);
                shapes[List_Drawn_Figures.SelectedIndex].Y1 = Convert.ToInt32(TBY1.Text);
                shapes[List_Drawn_Figures.SelectedIndex].X2 = Convert.ToInt32(TBX2.Text);
                shapes[List_Drawn_Figures.SelectedIndex].Y2 = Convert.ToInt32(TBY2.Text);

                Pen p = new Pen(Color.FromArgb(ChoosenShape.PC));
                p.Width = ChoosenShape.PW;
                SelectedShape.SetSel(ChoosenShape.X1, ChoosenShape.Y1, ChoosenShape.X2, ChoosenShape.Y2, p);

                pictureBox_Editor.Refresh();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SelectedShape.SetFalse();
            pictureBox_Editor.Refresh();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
              if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                  return;
              string filename = saveFileDialog1.FileName + ".json";

              Type type = shapes.GetType();
              DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Shape>), arrList);
              using (FileStream fs = new FileStream(filename, FileMode.Create))
              {
                  jsonFormatter.WriteObject(fs, shapes);
              }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string strEncoding;
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Shape>), arrList);
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                byte[] array = new byte[fs.Length];
                fs.Read(array, 0, array.Length);
                strEncoding = Encoding.Default.GetString(array); 
            }

            shapes.Clear();
            int i = 1;
            string buff = String.Empty;
            try
            {
                while (i < strEncoding.Length)
                {
                    while (strEncoding[i] != '}')
                    {
                        buff += strEncoding[i];
                        i++;
                    }
                    buff += strEncoding[i];
                    i++;
                    i++;

                    string bufFile = "bufFile.json";
                    File.WriteAllText(bufFile, buff);

                    Type type = shapes.GetType();
                    try
                    {
                        jsonFormatter = new DataContractJsonSerializer(typeof(Shape), arrList);
                        using (FileStream fs = new FileStream(bufFile, FileMode.OpenOrCreate))
                        {
                            shapes.Add((Shape)jsonFormatter.ReadObject(fs));
                        }
                        List_Drawn_Figures.Items.Add(shapes[shapes.Count - 1]);
                    }
                    catch
                    {}
                    buff = String.Empty;
                }
            }
            catch
            {}
            pictureBox_Editor.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChoosenShape = (Shape)List_Drawn_Figures.SelectedItem;
            if (ChoosenShape is ISelectable)
            {
                Pen p = new Pen(Color.FromArgb(ChoosenShape.PC));
                p.Width = ChoosenShape.PW;
                SelectedShape.SetSel(ChoosenShape.X1, ChoosenShape.Y1, ChoosenShape.X2, ChoosenShape.Y2, p);
                PanCol.BackColor = Color.FromArgb(ChoosenShape.PC);
                TBX1.Text = Convert.ToString(ChoosenShape.X1);
                TBY1.Text = Convert.ToString(ChoosenShape.Y1);
                TBX2.Text = Convert.ToString(ChoosenShape.X2);
                TBY2.Text = Convert.ToString(ChoosenShape.Y2);
                TBPW.Text = Convert.ToString(ChoosenShape.PW);
                pictureBox_Editor.Refresh();
            }
        }
    }
}
