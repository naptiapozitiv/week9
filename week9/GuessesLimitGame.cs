using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9
{
    class GuessesLimitGame : Game
    {
        private readonly int guessLimit;
        protected int guessCount;

        public GuessesLimitGame(int limit)
        {
            guessLimit = limit;
            guessCount = 0;
        }

        public override void StartGame()
        {
            while (guessCount < guessLimit || guessLimit == 0)
            {
                if (MakeGuess())
                {
                    Console.WriteLine("You've guessed the number!");
                    break;
                }

                guessCount++;

                if (guessLimit > 0 && guessCount >= guessLimit)
                {
                    Console.WriteLine("Out of guesses! Game over.");
                    break;
                }
            }
        }
    }
}
