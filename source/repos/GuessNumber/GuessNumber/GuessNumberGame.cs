using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    public enum GuessingPlayer
    {
        Human,
        Machine
    }

    public class GuessNumberGame
    {

        private readonly int max;
        private readonly int maxTries;
        private readonly GuessingPlayer guessingPlayer;

        public GuessNumberGame(int max = 100, int maxTries = 5, GuessingPlayer guessingPlayer = GuessingPlayer.Human)
        {
            this.max = max;
            this.maxTries = maxTries;
            this.guessingPlayer = guessingPlayer;
        }

        public void Start()
        {
            if (guessingPlayer == GuessingPlayer.Human)
            {
                HumanGuesses();
            }
            else
            {
                MachineGuesses();
            }
        }

        private void MachineGuesses()
        {

            int guessedNumber = -1;

            while (guessedNumber == -1)
            {
                try
                {
                    Console.WriteLine("Enter a number that's going to be guessed by a computer:");
                    int parsedNumber = int.Parse(Console.ReadLine());
                    if (parsedNumber >= 0 && parsedNumber <= this.max)
                        guessedNumber = parsedNumber;
                    else
                        Console.WriteLine("The number is less than 0 or greater than 100");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Try again: {ex.Message}");
                }

            }

            int lastGuess = -1;
            int min = 0;
            int max = this.max;
            int tries = 0;

            while (lastGuess != guessedNumber && tries < maxTries)
            {
                lastGuess = min + (max - min) / 2;
                Console.WriteLine($"Did you guess this number - {lastGuess}");
                Console.WriteLine($"If yes - enter 'y', if your number is greater - enter 'g', if less - 'l'");


                string answer = Console.ReadLine().ToLower();
                bool finished = false;

                switch (answer)
                {
                    case "y":
                        Console.WriteLine("You guessed the number");
                        finished = true;
                        break;
                    case "g":
                        Console.WriteLine("Number is greater");
                        min = lastGuess;
                        break;
                    case "l":
                        Console.WriteLine("Number is less");
                        max = lastGuess;
                        break;

                }

                if (finished)
                    break;

                if (lastGuess == guessedNumber)
                    Console.WriteLine("Don't cheat, man!");

                tries++;

                if (tries == maxTries)
                    Console.WriteLine("No tries anymore. I lost :C");

            }
        }

        private void HumanGuesses()
        {
            Random rand = new Random();
            int guessedNumber = rand.Next(0, max);

            int lastGuess = -1;
            int tries = 0;

            while (lastGuess != guessedNumber && tries < maxTries)
            {
                Console.WriteLine("Guess the number!");
                lastGuess = int.Parse(Console.ReadLine());

                if (lastGuess == guessedNumber)
                {
                    Console.WriteLine("Congrats! You guessed the number");
                    break;
                }
                else if (lastGuess < guessedNumber)
                    Console.WriteLine("My number is greater");
                else
                    Console.WriteLine("My number is less");

                tries++;
                
                if (tries == maxTries)
                {
                    Console.WriteLine("You lost the game!");
                }
            }
        }
    }
}
