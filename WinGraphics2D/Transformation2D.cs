using System;

namespace WinGraphics2D
{
    public class Transformation2D
    {

        public static float[,] RightTranslationMatrix(float tx, float ty)
        {
            float[,] R = { { 1, 0, 0 }, { 0, 1, 0 }, { tx, ty, 1 } };
            return R;
        }

        public static float[,] RightRotationMatrix(double angle)
        {
            float sin = Convert.ToSingle(Math.Sin(angle));
            float cos = Convert.ToSingle(Math.Cos(angle));
            float[,] R = { { cos, -sin, 0 }, { sin, cos, 0 }, { 0, 0, 1 } };
            return R;
        }

        public static float[,] RightRotationAboutPointMatrix(float x0, float y0, double angle)
        {
            float sin = Convert.ToSingle(Math.Sin(angle));
            float cos = Convert.ToSingle(Math.Cos(angle));
            float[,] R = { { cos, sin, 0 }, { -sin, cos, 0 }, { x0 * (1 - cos) + y0 * sin, y0 * (1 - cos) - x0 * sin, 1 } };
            return R;
        }
        public static float[,] ScalingMatrix(float sx, float sy)
        {
            float[,] R = { { sx, 0, 0 }, { 0, sy, 0 }, { 0, 0, 1 } };


            return R;
        }

        public static float[,] MatrixMultiplication(float[,] A, float[,] B)
        {
            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int colsB = B.GetLength(1);

            float[,] result = new float[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            return result;
        }


    }
}
