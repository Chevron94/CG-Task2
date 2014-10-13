using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Figure = null;
            Graphics gr = Canvas.CreateGraphics();
            gr.Clear(Color.White);
            Canvas.Refresh();
            Inp_Light_Dir.Text = "0 -40 40";
            Inp_Cam_Pos.Text = "0 -40 40";
            Inp_Cam_Dir.Text = "0 0 0";
            Inp_Len.Text = "10";
            Inp_W.Text = "10";
            Inp_H.Text = "10";
            Inp_Pyram1_H.Text = "5";
            Inp_Pyram2_H.Text = "5";
            Camera_Angle.Value = 90;
            Color = Color.Blue;
     //       Application.Idle += MyIdle;
        }

        private Viewport Figure;
        private Vector CamPos;
        private Vector CamDir;
        private Vector LightDir;
        private Color Color;
        private int length;
        private int width;
        private int height;
        private int pyram1_height;
        private int pyram2_height;

        private void SetColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Color = colorDialog1.Color;

            }
        }

        bool Check_Data()
        {
            return Int32.TryParse(Inp_Len.Text, out height) && Int32.TryParse(Inp_W.Text, out width) &&
                Int32.TryParse(Inp_H.Text, out length) && Int32.TryParse(Inp_Pyram1_H.Text, out pyram1_height) &&
                Int32.TryParse(Inp_Pyram2_H.Text, out pyram2_height) && FormVectors(Inp_Cam_Pos.Text, out CamPos) &&
                FormVectors(Inp_Cam_Dir.Text, out CamDir) && FormVectors(Inp_Light_Dir.Text, out LightDir);
        }

        void MyIdle(object sender, EventArgs e)
        {
        }
        private bool FormVectors(string inp, out Vector v)
        {
            string[] position_arr = inp.Split(' ');
            int i;
            int[] tmp_arr = { Int32.MinValue, Int32.MinValue, Int32.MinValue};
            if (position_arr.Length < 3)
            {
                v = null;
                return false;
            }
            i = 0;
            foreach (string tmp in position_arr)
            {
                if (Int32.TryParse(tmp, out tmp_arr[i]) && i < 3)
                    i++;
            }
            if (i < 2)
            {
                v = null;
                return false;
            }
            v = new Vector(tmp_arr[0], tmp_arr[1], tmp_arr[2]);
            return true;
        }
        private void Draw_Click(object sender, EventArgs e)
        {
            if (Check_Data())
            {
                Figure = new Viewport(Canvas.Height, Canvas.Width, new Camera(CamPos, CamDir.substract(CamPos), Convert.ToDouble(Camera_Angle.Value)), new LightPoint(LightDir), height, width, length, pyram1_height, pyram2_height, Color);
                Figure.Render();
                Canvas.Image = Figure.pic;
            }
            else MessageBox.Show("Неверные данные");
        }
    }
}
