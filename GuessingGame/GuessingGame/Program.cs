using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWorld = "lion";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            while (guess != secretWorld && !outOfGuesses);

            if (outOfGuesses)
            {
                Console.WriteLine("You lose");
            } else
            {
                Console.WriteLine("You win! You guessed the correct word in " + guessCount + " try");
            }
            Console.ReadLine();
        }
    }
}
