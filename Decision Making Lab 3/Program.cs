using System;

namespace Lab3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! What is your name?");
            string userName = Console.ReadLine();

            char userContinue = 'y';
            
            while (userContinue == 'y')
            {
                Console.WriteLine("Please enter a number between 1 and 100.");
                int input = int.Parse(Console.ReadLine());

                if ((input % 2 == 0) && (input >= 2) && (input < 25))
                {
                    Console.WriteLine($"{userName}, your number is Even and less than 25.");
                }
                if ((input % 2 == 0) && (input >= 26) && (input <= 60))
                {
                    Console.WriteLine($"{userName}, your number is Even.");
                }
                if ((input % 2 == 0) && (input >= 60) && (input <= 100))
                {
                    Console.WriteLine($"{userName}, {input} is Even.");
                }
                else if ((input % 2 == 1) && (input >= 1) && (input < 100))
                {
                    Console.WriteLine($"{userName}, {input} is Odd.");
                }

                if ((input <= 0) || (input >= 100))
                {
                    Console.WriteLine("Please make sure your number is between 1 and 100.");
                }

                Console.WriteLine($"Would you like to conitinue, {userName}? (y/n)");
                userContinue = char.Parse(Console.ReadLine().ToLower());

                if (userContinue == 'n')
                {
                    Console.WriteLine($"Goodbye, {userName}, thanks for visiting!");
                }
            }
        }
    }
}
