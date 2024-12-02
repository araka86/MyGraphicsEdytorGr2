using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinGraphics2D
{
    public partial class Form1 : Form
    {
        public Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();


            // Очистка PictureBox
            pictureBox1.Image = null;

            // Ширина и высота PictureBox
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            // Создаем пустое изображение
             bitmap = new Bitmap(width, height);


            // Инициализация колонок DataGridView
            dataGridView1.Columns.Add("PointIndex", "X");
            dataGridView1.Columns.Add("XCoordinate", "Y");
            dataGridView1.Columns.Add("YCoordinate", "Z");


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




          
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                //   g.Clear(Color.White); // Заполняем белым цветом + очистка

                // Базовый квадрат (или другая фигура)
                PointF[] points = {
                    new PointF(92, 82),
                    new PointF(245, 53),
                    new PointF(228, 134),
                    new PointF(202, 81),
                    new PointF(161, 246)
                };


              



                // Применяем преобразования
                float[,] transformationMatrix = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

                if (checkBoxTranslation.Checked)
                {
                    float tx = float.Parse(textBoxTranslationX.Text);
                    float ty = float.Parse(textBoxTranslationY.Text);
                    transformationMatrix = Transformation2D.MatrixMultiplication(transformationMatrix, Transformation2D.RightTranslationMatrix(tx, ty));
                }
                if (checkBoxRotation.Checked)
                {
                    double angle = double.Parse(textBoxRotation.Text) * Math.PI / 180; // Угол в радианах
                    transformationMatrix = Transformation2D.MatrixMultiplication(transformationMatrix, Transformation2D.RightRotationMatrix(angle));
                }
                if (checkBoxRotationAround.Checked)
                {
                    float x0 = float.Parse(textBoxRotationAroundX.Text);
                    float y0 = float.Parse(textBoxRotationAroundY.Text);
                    double angle = double.Parse(textBoxRotationAroundAngle.Text) * Math.PI / 180; // Угол в радианах
                    transformationMatrix = Transformation2D.MatrixMultiplication(transformationMatrix, Transformation2D.RightRotationAboutPointMatrix(x0, y0, angle));
                }
                if (checkBoxScaling.Checked)
                {
                    float sx = float.Parse(textBoxScalingX.Text);
                    float sy = float.Parse(textBoxScalingY.Text);
                    transformationMatrix = Transformation2D.MatrixMultiplication(transformationMatrix, Transformation2D.ScalingMatrix(sx, sy));
                }



                // Преобразуем точки
                PointF[] transformedPoints = ApplyTransformation(points, transformationMatrix);

                // Рисуем преобразованную фигуру
                g.DrawPolygon(Pens.Black, transformedPoints);

                // Устанавливаем изображение в PictureBox
                pictureBox1.Image = bitmap;
                UpdateDataGridView(transformedPoints);

            }



        }


        private void UpdateDataGridView(PointF[] points)
        {
            // Очищаем предыдущие данные
          //  dataGridView1.Rows.Clear();

            // Добавляем новые данные
            for (int i = 0; i < points.Length; i++)
            {
                // dataGridView1.Rows.Add($"Точка {i + 1}", points[i].X, points[i].Y);
                dataGridView1.Rows.Add( points[i].X, points[i].Y,"1");
            }

            dataGridView1.Rows.Add($" ", " ", " ");
        }


        private PointF[] ApplyTransformation(PointF[] points, float[,] matrix)
        {
            PointF[] result = new PointF[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                float x = points[i].X;
                float y = points[i].Y;
                result[i] = new PointF(
                    x * matrix[0, 0] + y * matrix[1, 0] + matrix[2, 0],
                    x * matrix[0, 1] + y * matrix[1, 1] + matrix[2, 1]
                );
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Очистка PictureBox
            pictureBox1.Image = null;

            // Ширина и высота PictureBox
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            // Создаем пустое изображение
            bitmap = new Bitmap(width, height);
        }
    }
}
