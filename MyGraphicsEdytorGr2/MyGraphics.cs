using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGraphicsEdytorGr2
{
    public class MyGraphics
    {

        //          MyGraphics.myLine(10,    50,     250,     50, bitmap, pictureBox1, Color.Red);
        public static void myLine(int x0, int y0, int x1, int y1, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int dl;//lichba iteracji
            int width = bitmap.Width - 1;
            int height = bitmap.Height - 1;

            ///////////////horizont
            if (y1 == y0) //linia pizioma
            {
                int xi = x0;
                int dx;
                if (x0 < x1) dx = 1; else dx = -1;
                dl = Math.Abs(x1 - x0); 
                for (int i = 0; i <= dl; i++)
                {
                    bitmap.SetPixel(xi, y0, color);
                    xi += dx;
                }
                pictureBox.Image = bitmap;
                return;
            }

            /////////////////vertikal//
            if (x1 == x0) //linia pionowa
            {
                int yi = y0;
                int dy;
                if (y0 < y1) dy = 1; else dy = -1;
                dl = Math.Abs(y1 - y0);
                for (int i = 0; i <= dl; i++)
                {
                    bitmap.SetPixel(x0 + 1, yi, color);
                    yi += dy;

                }
                pictureBox.Image = bitmap;
                return;
            }





////////// ////////////////liniya uklona//////////////////////////////////////////
            float m = (float)(y1 - y0) / (x1 - x0);
            float xii = x0, yii = y0;
            float delta_x, delta_y;

         
            if (Math.Abs(x1 - x0) >= Math.Abs(y1 - y0))
            {
                dl = Math.Abs(x1 - x0);
                if (x0 < x1) delta_x = 1; else delta_x = -1;
                delta_y = m * delta_x;

              
                for (int i = 0; i < dl; i++)
                {
                    //    bitmap.SetPixel((int)xii, (int)yii, color);
                    //    xii += delta_x; 
                    //    yii += delta_y;

                    if ((xii > 1) && (xii < width) && (yii > 1) && (yii < height))
                    {
                        bitmap.SetPixel((int)xii, (int)yii, color);
                        xii += delta_x; 
                        yii += delta_y;
                    }
                }
            }
            else
            {
                dl = Math.Abs(y1 - y0);
                if (y0 < y1) delta_y = 1; else delta_y = -1;
                delta_x = delta_y / m;

                for (int i = 0; i <= dl; i++)
                {
                    //bitmap.SetPixel((int)xii, (int)yii, color);
                    //xii += delta_x;
                    //yii += delta_y;

                    if ((xii > 1) && (xii < width) && (yii > 1) && (yii < height))
                    {
                        bitmap.SetPixel((int)xii, (int)yii, color);
                        xii += delta_x; 
                        yii += delta_y;
                    }
                }
            }
            pictureBox.Image = bitmap;
        }


        //Изменяя начальные и конечные углы в цикле, можно управлять направлением полукруга в нужную сторону.
        //full circle 0 360

        //right -90 90
        //left 90 270
        //up 180 360
        // down 0 180
        public static void Mycircle(int x0, int y0, float r, Bitmap bitmap, PictureBox pictureBox, Color color) 
        {

            int xi, yi;
            for (int i = 0; i < 180; i++){
                xi = (int)(x0 + r * Math.Cos(i * Math.PI / 180));
                yi = (int)(y0 + r * Math.Sin(i * Math.PI / 180));
                bitmap.SetPixel(xi, yi, color);
            }
            pictureBox.Image = bitmap;
        }

        public static void MyRadiuscircle(int x0, int y0, float r, int istart, int istop, Bitmap bitmap, PictureBox pictureBox, Color color)
        {

            int xi, yi;
            for (int i = istart; i < istop; i++)
            {
                xi = (int)(x0 + r * Math.Cos(i * Math.PI / 180));
                yi = (int)(y0 + r * Math.Sin(i * Math.PI / 180));
                bitmap.SetPixel(xi, yi, color);
            }
            pictureBox.Image = bitmap;
        }


        public static void myElipse(int x0, int y0, int a, int b,Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int xi, yi,iteration = 360;
            int width = bitmap.Width-1;
            int height = bitmap.Height -1;
            for (int i = 0; i < iteration; i++)
            {
                xi = (int)(x0 + a * Math.Cos(i * Math.PI / 100));
                yi= (int)(y0 + b * Math.Sin(i* Math.PI /100));
                if ((xi > 1) && (xi < width) && (yi > 1) && (yi < height))
                    bitmap.SetPixel(xi, yi, color); 
            }
            pictureBox.Image = bitmap;
        }


    }
}
