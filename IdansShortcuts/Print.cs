using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdansShortcuts
{
    public class Print
    {
        public static void Array<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            { Console.Write(array[i]); if (i < array.Length - 1) Console.Write(", "); }
        }

        public static void Matrix<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                { Console.Write(matrix[i, j]); if (j < matrix.GetLength(1) - 1) Console.Write(", "); }
                Console.WriteLine();
            }
        }
        
    }
}
