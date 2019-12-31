using System;
using System.Diagnostics;
using System.Text;
using Coding.Exercise;
using Coding.OriginalExercise;

namespace CodeExercise3
{
    class Program
    {
        private static void PrintOldMatrix(OriginalMatrix value)
        {
            StringBuilder builder = new StringBuilder();
            for (int r = 0; r < value.Rows; r++)
            {
                builder.Clear();
                builder.Append("| ");
                for (int c = 0; c < value.Columns; c++)
                {
                    builder.Append(String.Format("{0,3}", value[r, c])).Append(" ");
                }
                builder.Append("|");

                Console.WriteLine(builder.ToString());
            }
            Console.WriteLine();
        }

        private static void PrintMatrix(Matrix value)
        {
            StringBuilder builder = new StringBuilder();
            for (int r = 0; r < value.Rows; r++)
            {
                builder.Clear();
                builder.Append("| ");
                for (int c = 0; c < value.Columns; c++)
                {
                    builder.Append(String.Format("{0,3}", value[r, c])).Append(" ");
                }
                builder.Append("|");

                Console.WriteLine(builder.ToString());
            }
            Console.WriteLine();
        }

        public static void OldCode()  {
            OriginalMatrix matrix1 = new OriginalMatrix(new int[,] {
                { 1, 2, 3 },
                { 4, 5, 6 }
            });
            Program.PrintOldMatrix(matrix1);

            OriginalMatrix matrix2 = new OriginalMatrix(new int[,] {
                { 7, 8 },
                { 9, 10 },
                { 11, 12 }
            });
            Program.PrintOldMatrix(matrix2);

            OriginalMatrix resultMatrix = OriginalExercise.Multiply(matrix1, matrix2);

            Program.PrintOldMatrix(resultMatrix);
        }

        public static void NewCode()  {
             Matrix matrix1 = new Matrix(new int[,] {
                { 1, 2, 3 },
                { 4, 5, 6 }
            });
            Program.PrintMatrix(matrix1);

            Matrix matrix2 = new Matrix(new int[,] {
                { 7, 8 },
                { 9, 10 },
                { 11, 12 }
            });
            Program.PrintMatrix(matrix2);

            Matrix resultMatrix = Exercise.Multiply(matrix1, matrix2);

            Program.PrintMatrix(resultMatrix);
        }

        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();
            Program.OldCode();
            watch.Stop();

            Console.WriteLine("Original code: " + watch.ElapsedMilliseconds + "ms");

            watch.Reset();
            watch.Start();
            Program.NewCode();
            watch.Stop();

            Console.WriteLine("Improved code: " + watch.ElapsedMilliseconds + "ms");
        }
    }
}
