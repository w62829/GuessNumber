using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    public static class Random1
    {
        public static int Newnum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
    public static class Game
    {
        public static int[] Guess(int input)
        {
            while (true)
            {
                int randno = Random1.Newnum(1, 101);
                int count = 1;
                while (true)
                {
                    Console.Write("Enter a number between 1 and 100(0 to quit):");
                 
                    if (input == 0)
                        break;
                    else if (input < randno)
                    {
                        Console.WriteLine("Too small.");
                        count++;
                        continue;
                    }
                    else if (input > randno)
                    {
                        Console.WriteLine("Too big.");
                        count++;
                        continue;
                    }
                    else if (input == randno)
                    {
                        Console.WriteLine($"You won! The number was {randno}!");

                        Console.WriteLine("It took you {0} {1}.\n", count,
                                           count == 1 ? "try" : "tries");
                        break;
                    }
                }
            }
        }            
             
    }
}
