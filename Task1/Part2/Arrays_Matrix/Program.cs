using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Matrix
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The result of dimension of two matrix:");
            double [,] my_arr = new double[,] {{ 2, 2, 3}, { 5, 2, 8}};
            double[,] my_arr2 = new double[,] { { 2, 4, 8 }, { 1, 3, 1}};

            var n = my_arr.GetLength(0);  /* number of strings*/
            var m = my_arr.GetLength(1); /* number of columns */

            Console.WriteLine("The first matrix is:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("{0} ", my_arr[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("The second matrix is:");
            for (int i = 0; i < my_arr2.GetLength(0); i++)
            {
                for (int j = 0; j < my_arr2.GetLength(1); j++)
                    Console.Write("{0} ", my_arr2[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("The result is:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                   double [,] S = new double[n,m];
                   S[i, j] = 0;
                   for (int k = 0; k < n; k++)
                   {
                       S[i, j] += my_arr[i, k] * my_arr2[k, j];
                       
                   }
                   Console.Write(S[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
