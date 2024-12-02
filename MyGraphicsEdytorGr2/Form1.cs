using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGraphicsEdytorGr2
{


    public partial class myCircle : Form
    {

        Bitmap bitmap, bimapClone;
        enum Tools { none, line, circle };
        Tools tool = Tools.none;
        int x0, y0;
        float r;
        bool mouseDown = false;



        int istart=0, 
            istop=360;

        public myCircle()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            rbleft.CheckedChanged += RadioButton_CheckedChanged;
            rbright.CheckedChanged += RadioButton_CheckedChanged;
            rbup.CheckedChanged += RadioButton_CheckedChanged;
            rbdown.CheckedChanged += RadioButton_CheckedChanged;
            rbfull.CheckedChanged += RadioButton_CheckedChanged;

        }



        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Получаем RadioButton, вызвавшую событие
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                switch (selectedRadioButton.Text)
                {
                    case "up":
                        istart = 180;
                        istop = 360;
                        break;
                    case "down":
                        istart = 0;
                        istop = 180;
                        break;
                    case "left":
                        istart = 90;
                        istop = 270;
                        break;
                    case "right":
                        istart = -90;
                        istop = 90;
                        break;
                    default:
                        istart = 0;
                        istop = 360;
                        break;
                }
            }
        }




        //активация линии
        private void btnLine_Click(object sender, EventArgs e)
        {
            //  bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            //х,y, длинна линии,хз, обьект, екземпляр окна, цвет
            //    MyGraphics.myLine(10, 50, 250, 50, bitmap, pictureBox1, Color.Red);
            //  MyGraphics.myLine(50, 150, 100, 60, bitmap, pictureBox1, Color.Green);


            //MyGraphics.myLine(int.Parse(nuvx0.Text),
            //    int.Parse(nuvy0.Text),
            //    int.Parse(nuvx1.Text),
            //    int.Parse(nuvy1.Text), bitmap, pictureBox1, Color.Red);

            tool = Tools.line;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bitmap = null;
            pictureBox1.Image = null;
        }

        //add
        private void button2_Click(object sender, EventArgs e)
        {

            if (bitmap == null) bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Random random = new Random();
            //var colorProperties = typeof(Color)
            //    .GetProperties()
            //    .Where(prop => prop.PropertyType == typeof(Color))
            //    .ToArray();

            //Color randomColor = (Color)colorProperties[random.Next(colorProperties.Length)].GetValue(null);


            Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Black };

            // Select a random color
            Color randomColor = colors[random.Next(colors.Length)];



            MyGraphics.myLine(int.Parse(nuvx0.Text),
             int.Parse(nuvy0.Text),
             int.Parse(nuvx1.Text),
             int.Parse(nuvy1.Text), bitmap, pictureBox1, randomColor);
        }


        //CustomLine
        private void custumLine_Click(object sender, EventArgs e)
        {

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            MyGraphics.myLine(int.Parse(nuvx0.Text),
                int.Parse(nuvy0.Text),
                int.Parse(nuvx1.Text),
                int.Parse(nuvy1.Text), bitmap, pictureBox1, Color.Red);

        }

        private void button3_Click(object sender, EventArgs e)
        {



            nuvx0.Value = 0;
            nuvx1.Value = 0;
            nuvy1.Value = 0;
            nuvy0.Value = 0;

        }




        //момент опускания
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if ((tool != Tools.none) && (mouseDown))
            {

                switch (tool)
                {
                    case Tools.line:
                        MyGraphics.myLine(x0, y0, e.X, e.Y, bitmap, pictureBox1, Color.Red);
                        break;
                    case Tools.circle:
                        r = (float)Math.Sqrt((e.X - x0) * (e.X - x0) + (e.Y - y0) + (e.Y - y0));
                        // MyGraphics.Mycircle(x0, y0, r, bitmap, pictureBox1, Color.Blue);

                        MyGraphics.MyRadiuscircle(x0,
                                                 y0,
                                                 r, 
                                                  istart, 
                                                  istop, 
                                                  bitmap, 
                                                  pictureBox1, 
                                                  Color.Red);
                        break;

                }
                mouseDown = false;

            }
        }





        //момент наведения
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((tool != Tools.none) && (mouseDown))
            {

                bimapClone = (Bitmap)bitmap.Clone();
                switch (tool)
                {
                    case Tools.line:
                        MyGraphics.myLine(x0, y0, e.X, e.Y, bitmap, pictureBox1, Color.Red);
                        break;




                }
                bitmap = bimapClone;


            }
        }

        private void myElipse_Click(object sender, EventArgs e)
        {
            MyGraphics.myElipse(200,200,80,40,bitmap, pictureBox1, Color.Red);
        }

        //момент нажатия
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (tool != Tools.none)
            {
                x0 = e.X;
                y0 = e.Y;
                mouseDown = true;
            }
        }











        private void btnNone_Click(object sender, EventArgs e)
        {
            tool = Tools.none;

        }




        private void btnCircle_Click(object sender, EventArgs e)
        {
            tool = Tools.circle;

            //MyGraphics.Mycircle(int.Parse(CnmX.Text),
            //    int.Parse(CnmY.Text),
            //    int.Parse(CnmR.Text), bitmap, pictureBox1, Color.Red);


            //MyGraphics.MyRadiuscircle(int.Parse(CnmX.Text),
            //    int.Parse(CnmY.Text),
            //     int.Parse(CnmR.Text), istart,istop, bitmap, pictureBox1, Color.Red);
        }

    }
}
