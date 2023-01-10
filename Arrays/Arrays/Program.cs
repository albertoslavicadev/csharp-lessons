using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 16, 42 }; // Come scrivere le array
                                                   // 0, 1, 2,  3 ->

            string[] friends = new string[5];
            friends[0] = "Alberto";

            luckyNumbers[1] = 900;
            Console.WriteLine(luckyNumbers[1]);

            Console.ReadLine();
        }
    }
}
