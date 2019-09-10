using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            Random number = new Random();

            int number1 = number.Next(1, 100);

            Console.WriteLine($"Greatings in \"Integer guesser\"! I'll guess a number from 1 to 100, and you should find this number. Let's get started, enter a number:\n");

            while (flag)
            {
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer > 100 || answer < 1)
                {
                    Console.WriteLine($"\nWrong number, enter a number from 1 to 100:\n");
                }
                else if (answer > number1)
                {
                    Console.WriteLine($"\nThe guessed number is less, try again:\n");
                }
                else if (answer < number1)
                {
                    Console.WriteLine($"\nThe guessed number is bigger, try again:\n");
                }
                else if (number1 == answer)
                {
                    Console.WriteLine($"\nGreat you won! See you next time.");

                    flag = false;

                }
            }
            Console.ReadLine();
        }
    }
}
