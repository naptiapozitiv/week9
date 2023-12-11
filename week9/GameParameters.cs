using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9
{
    class GameParameters
    {
        private int hardTimeLimit;
        private int mediumTimeLimit;
        private int hardGuessesLimit;
        private int mediumGuessesLimit;

        public int Level { get; set; }
        public string Mode { get; set; }
        public int Limit { get; set; }

        public GameParameters()
        {
            if (!int.TryParse(Environment.GetEnvironmentVariable("HARD_TIME_LIMIT"), out hardTimeLimit))
            {
                hardTimeLimit = 1; // Значение по умолчанию или другое подходящее значение
            }

            if (!int.TryParse(Environment.GetEnvironmentVariable("MEDIUM_TIME_LIMIT"), out mediumTimeLimit))
            {
                mediumTimeLimit = 3; // Значение по умолчанию или другое подходящее значение
            }

            if (!int.TryParse(Environment.GetEnvironmentVariable("HARD_GUESSES_LIMIT"), out hardGuessesLimit))
            {
                hardGuessesLimit = 10; // Значение по умолчанию или другое подходящее значение
            }

            if (!int.TryParse(Environment.GetEnvironmentVariable("MEDIUM_GUESSES_LIMIT"), out mediumGuessesLimit))
            {
                mediumGuessesLimit = 30; // Значение по умолчанию или другое подходящее значение
            }
        }

        public void ChooseGameLevel()
        {
            Console.WriteLine("Choose game level (1: Easy, 2: Medium, 3: Hard): ");
            Level = int.Parse(Console.ReadLine());
        }

        public void ChooseGameMode()
        {
            Console.WriteLine("Choose game mode (T for time, N for number of guesses): ");
            Mode = Console.ReadLine().ToUpper();
        }

        public void SetUpLimit()
        {
            if (Mode == "T")
            {
                Limit = (Level == 3) ? hardTimeLimit : (Level == 2) ? mediumTimeLimit : 0;
            }
            else if (Mode == "N")
            {
                Limit = (Level == 3) ? hardGuessesLimit : (Level == 2) ? mediumGuessesLimit : 0;
            }
        }
    }
}
