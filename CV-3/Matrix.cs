using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_3
{
    public class Matrix
    {
        private double[,] matrix;
        private int rows;
        private int columns;


        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;
            this.rows = matrix.GetLength(0);
            this.columns = matrix.GetLength(1);
        }

        public static Matrix operator +(Matrix matrixA, Matrix matrixB)
        {
            double[,] nullMatrix = new double[matrixA.rows, matrixA.columns];
            Matrix matrix = new Matrix(nullMatrix);

            try
            {
                for (int i = 0; i < matrixA.rows; i++)
                {
                    for (int j = 0; j < matrixA.columns; j++)
                    {
                        matrix.matrix[i, j] = matrixA.matrix[i, j] + matrixB.matrix[i, j];
                    }
                }

                return matrix;
            }
            catch
            {
                Console.WriteLine("Cant sum Matrixes, not compatible number of rows and columns");
                return null;
            }
        }

        public static Matrix operator -(Matrix matrixA, Matrix matrixB)
        {
            double[,] nullMatrix = new double[matrixA.rows, matrixA.columns];
            Matrix matrix = new Matrix(nullMatrix);

            try
            {
                for (int i = 0; i < matrixA.rows; i++)
                {
                    for (int j = 0; j < matrixA.columns; j++)
                    {
                        matrix.matrix[i, j] = matrixA.matrix[i, j] - matrixB.matrix[i, j];
                    }
                }

                return matrix;
            }
            catch
            {
                Console.WriteLine("Cant diff Matrixes, not compatible number of rows and columns");
                return null;
            }
        }

        public static Matrix operator *(Matrix matrixA, Matrix matrixB)
        {
            double[,] nullMatrix = new double[matrixA.rows, matrixB.columns];
            Matrix matrix = new Matrix(nullMatrix);

            try
            {
                for (int i = 0; i < matrixA.rows; i++)
                {
                    for (int j = 0; j < matrixB.columns; j++)
                    {
                        for (int k = 0; k < matrixA.columns; k++)
                        {
                            matrix.matrix[i, j] += matrixA.matrix[i, k] * matrixB.matrix[k, j];
                        }
                    }
                }

                return matrix;
            }
            catch
            {
                Console.WriteLine("Cant multiply Matrixes, not compatible number of rows and columns");
                return null;
            }

        }

        public static Matrix operator -(Matrix matrixA)
        {
            double[,] nullMatrix = new double[matrixA.rows, matrixA.columns];
            Matrix matrix = new Matrix(nullMatrix);

            for (int i = 0; i < matrixA.rows; i++)
            {
                for (int j = 0; j < matrixA.columns; j++)
                {
                    matrix.matrix[i, j] = -matrixA.matrix[i, j];
                }
            }

            return matrix;
        }

        public static bool operator ==(Matrix matrixA, Matrix matrixB)
        {
            bool check = true;
            double epsilon = 1E-6;

            for (int i = 0; i < matrixA.rows; i++)
            {
                for (int j = 0; j < matrixA.columns; j++)
                {
                    if (Math.Abs(matrixA.matrix[i, j] - matrixB.matrix[i, j]) > epsilon)
                    {
                        check = false;
                        return check;
                    }
                }
            }

            return check;
        }

        public static bool operator !=(Matrix matrixA, Matrix matrixB)
        {
            return !(matrixA == matrixB);
        }

        /* In result of more readibility, function is not made into just one return, returns -1.1 if error */
        public static double Determinant(Matrix matrixA)
        {
            if(matrixA.rows == 3 && matrixA.columns == 3)
            {
                double result = 0;

                result += (matrixA.matrix[0, 0] * matrixA.matrix[1, 1] * matrixA.matrix[2, 2] +
                           matrixA.matrix[1, 0] * matrixA.matrix[2, 1] * matrixA.matrix[0, 2] +
                           matrixA.matrix[2, 0] * matrixA.matrix[0, 1] * matrixA.matrix[1, 2]);

                result -= (matrixA.matrix[1, 0] * matrixA.matrix[0, 1] * matrixA.matrix[2, 2] +
                           matrixA.matrix[0, 0] * matrixA.matrix[2, 1] * matrixA.matrix[1, 2] +
                           matrixA.matrix[2, 0] * matrixA.matrix[1, 1] * matrixA.matrix[0, 2]);

                return result;

            }
            Console.WriteLine("Cant do determinant of this matrix, needs to be 3x3...");
            return -1.1;
            
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder("");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                output.Append("{ ");

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var result = matrix[i, j] < 0 ? output.Append($"{matrix[i, j]} ") : output.Append($" {matrix[i, j]} ");
                }

                output.Append("}\n");
            }

            return output.ToString();
        }
    }
}
