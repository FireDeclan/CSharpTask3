using System;

namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            //Introduction
            uint pickLevel;
            Console.WriteLine("Welcome to the \"Guessing Game\"");
            Console.WriteLine("Please select a difficulty level: \n1. Easy \n2. Medium \n3. Hard");
            Console.Write("Difficulty level: ");

            //Input restriction
            while (!(uint.TryParse(Console.ReadLine(), out pickLevel)) || pickLevel>3 || pickLevel==0)
            {
                Console.Write("Oops! Unexpected response. Please try again(1, 2 or 3): ");
            }

            //Redirect to selected level method
            if (pickLevel == 1)
            {
                easy();
            }
            else if (pickLevel == 2)
            {
                medium();
            }
            else
            {
                hard();
            }
            
        }

        public static void easy()
        {
            Random numGen = new Random();
            int attempt = 1;
            int fixedNumber = numGen.Next(1,11);
            int guess;

            Console.WriteLine("\nYou have chosen Easy, you have 6 attempts to guess correctly");
            Console.Write("Guess a number between 1 and 10: ");

            //Input restriction
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.Write("Response was in the wrong format. Please type a number: ");
            }

            //Wrong guess loop
            while (attempt != 6 && fixedNumber != guess)
            {
                Console.WriteLine("That was wrong");
                Console.Write("You have "+(6-attempt)+ " attempt(s) left. Try again:");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Response was in the wrong format. Please type a number: ");
                }
                attempt++;
            }

            //Right guess and game over conditional
            if (fixedNumber == guess)
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("That was wrong.\nGame over!");
            }
            rePlay();
        }

        public static void medium()
        {
            Random numGen = new Random();
            int attempt = 1;
            int fixedNumber = numGen.Next(1,21);
            int guess;

            Console.WriteLine("\nYou have chosen Medium, you have 4 attempts to guess correctly");
            Console.Write("Guess a number between 1 and 20: ");

            //Input restriction
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.Write("Response was in the wrong format. Please type a number: ");
            }

            //Wrong guess loop
            while (attempt != 4 && fixedNumber != guess)
            {
                Console.WriteLine("That was wrong");
                Console.Write("You have "+(4-attempt)+ " attempt(s) left. Try again:");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Response was in the wrong format. Please type a number: ");
                }
                attempt++;
            }

            //Right guess and game over condition
            if (fixedNumber == guess)
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("That was wrong.\nGame over!");
            }
            rePlay();
        }

        public static void hard()
        {
            Random numGen = new Random();
            int attempt = 1;
            int fixedNumber = numGen.Next(1,51);
            int guess;

            Console.WriteLine("\nYou have chosen Hard, you have 3 attempts to guess correctly");
            Console.Write("Guess a number between 1 and 50: ");

            //Input restriction
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.Write("Response was in the wrong format. Please type a number: ");
            }

            //Failed guess loop
            while (attempt != 3 && fixedNumber != guess)
            {
                Console.WriteLine("That was wrong");
                Console.Write("You have "+(3-attempt)+ " attempt(s) left. Try again:");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Response was in the wrong format. Please type a number: ");
                }
                attempt++;
            }

            //Right guess and game over conditional
            if (fixedNumber == guess)
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("That was wrong.\nGame over!");
            }
            rePlay();
        }

        public static void rePlay()
        {
            uint answer;
            Console.Write("\nPlay again? (1 = Yes, 2 = No): ");
            while (!(uint.TryParse(Console.ReadLine(), out answer)) || answer>2 || answer==0)
            {
                Console.Write("Oops! Unexpected response. Please try again(1 or 2): ");
            }
            
            if (answer == 1)
            {
                Console.WriteLine();
                Main();
            }
            else
            {
                Console.WriteLine("\nGoodbye!");
            }
        }
    }
}
