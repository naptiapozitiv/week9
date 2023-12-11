using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9
{
    abstract class Game
    {
        protected int targetNumber;

        public Game()
        {
            targetNumber = new Random().Next(0, 101);
        }

        public abstract void StartGame();

        protected bool MakeGuess()
        {
            Console.WriteLine("Enter your guess: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == targetNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                return true;
            }
            else
            {
                Console.WriteLine((guess < targetNumber) ? "Target number is more." : "Target number is less.");
                return false;
            }
        }
    }
}
