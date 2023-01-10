using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParoleACaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = false;
            if (isMale && isTall) //specify a conditon inside the if statement  // && AND(both operators need to be true)
            {                                                                   // || OR(just one operator need to be true)
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall) // ! means that the bool is false
            {
                Console.WriteLine("You are a short male");
            } 
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a tall female");
            } 
            else
            {
                Console.WriteLine("You are a short female");
            }
            Console.ReadLine();
        }
    }
}
