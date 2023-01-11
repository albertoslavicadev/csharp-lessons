using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid = {  //can add more dimesions by simply adding a comma inside
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };

            Console.WriteLine(numberGrid[0, 1]);
            Console.ReadLine();
        }
    }
}
