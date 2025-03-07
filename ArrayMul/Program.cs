using System;
using System.Data;
using System.Globalization;
using System.Runtime.Versioning;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float [,] matrix1 = new float [2,1];
            

            matrix1[0, 0] = float.Parse(args[0], CultureInfo.InvariantCulture);
            matrix1[0, 1] = float.Parse(args[1], CultureInfo.InvariantCulture);
            matrix1[1, 0] = float.Parse(args[2], CultureInfo.InvariantCulture);
            matrix1[1, 1] = float.Parse(args[3], CultureInfo.InvariantCulture);
            float[] a = new float[2];

            float[,] matrix2 = new float[2, 1];

            matrix2[0, 0] = float.Parse(args[4], CultureInfo.InvariantCulture);
            matrix2[1, 0] = float.Parse(args[5], CultureInfo.InvariantCulture);

            float[,] result = new float[2, 1];

            for (int l = 0; l < 2; l++)
            {
                for (int j = 0; j < 1; j++)
                {
                    result[l, j] = 0;
                    for (int c = 0; c < 2; c++)
                    {
                        result[l, j] += matrix1[l, c] * matrix2[c, j];
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine($"| {result[i, j],7:F2} |");
                }
            }
        }
    }
}