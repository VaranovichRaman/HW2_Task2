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
            IntegerGuesser();
            Console.ReadLine();
        }
        static void IntegerGuesser()
        {
            Random rand = new Random();

            int number = rand.Next(1, 100);

            Console.WriteLine($"Greatings in \"Integer guesser\"! I'll guess a number from 1 to 100, and you should find this number. Let's get started, enter a number:\n");

            Choice(number);
        }
        static void Choice(int number)
        {
            bool flag = true;

            while (flag)
            {
                int result = AnswerCheck();

                if (result > number)
                {
                    Console.WriteLine($"\nThe guessed number is less, try again:\n");
                }
                else if (result < number)
                {
                    Console.WriteLine($"\nThe guessed number is bigger, try again:\n");
                }
                else if (number == result)
                {
                    Console.WriteLine($"\nGreat you won! See you next time.");

                    flag = false;

                }
            }
        }
        static int AnswerCheck()
        {
            int answer=0;
            bool flag = true;

            while (flag)
            {
                bool answerCheck = Int32.TryParse(Console.ReadLine(), out answer);

                if (answer > 100 || answer < 1 || answerCheck == false)
                {
                    Console.WriteLine($"\nWrong number, enter a number from 1 to 100:\n");
                }
                else
                {
                    flag = false;
                }
            }
            
            return answer;
        }
    }
}
