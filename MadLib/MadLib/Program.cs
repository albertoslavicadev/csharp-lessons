using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, adj, sause;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a pluralNoun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a adjective: ");
            adj = Console.ReadLine();
            Console.Write("Enter a sauce: ");
            sause = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("Ciao " + adj);
            Console.WriteLine("Vuoi " + sause);

            Console.ReadLine();
        }
    }
}
