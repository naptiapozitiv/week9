using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9
{
    class TimeLimitedGame : Game
    {
        private readonly int timeLimit;

        public TimeLimitedGame(int limit)
        {
            timeLimit = limit;
        }

        public override void StartGame()
        {
            DateTime startTime = DateTime.Now;
            while (true)
            {
                if (MakeGuess())
                {
                    Console.WriteLine("You've guessed the number!");
                    break;
                }

                if (timeLimit > 0 && (DateTime.Now - startTime).TotalMinutes >= timeLimit)
                {
                    Console.WriteLine("Time's up! Game over.");
                    break;
                }
            }
        }
    }
}
