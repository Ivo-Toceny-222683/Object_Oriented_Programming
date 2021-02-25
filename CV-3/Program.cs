using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double[,] mtA = new double[3, 4] { { 1, 2, 3, 4 },
                                               { 4, 5, 6, 7 },
                                               { 7, 8, 9, -2 } }; */

            double[,] mtA = new double[3, 3] { { 7, 2, 3 },
                                               { 4, 2, 6 },
                                               { 7, 8, 4 } };

            /*double[,] mtB = new double[3, 3] { { 1, 2, 3 },
                                               { 4, 5, 6 },
                                               { 7, 8, 9 } };*/

            double[,] mtB = new double[3, 3] { { 8, 7, 6 },
                                               { 5, 4, 3 },
                                               { 2, 1, 0 } };

            Matrix matrix = new Matrix(mtA);
            Matrix matrix2 = new Matrix(mtB);

            Console.WriteLine("A:\n{0}\nB:\n{1}", matrix, matrix2);

            Console.WriteLine("Sum: ");
            Console.WriteLine( matrix + matrix2);

            Console.WriteLine("Dif: ");
            Console.WriteLine(matrix - matrix2);

            Console.WriteLine("Multiply: ");
            Console.WriteLine(matrix * matrix2);

            Console.WriteLine("unary -: ");
            Console.WriteLine(-matrix);

            Console.WriteLine("==: ");
            Console.WriteLine(matrix == matrix2);
            Console.WriteLine("");

            Console.WriteLine("!=: ");
            Console.WriteLine(matrix != matrix2);
            Console.WriteLine("");

            Console.WriteLine("Determinant: ");
            Console.WriteLine(Matrix.Determinant(matrix));
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
