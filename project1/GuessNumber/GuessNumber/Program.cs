using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int number = rd.Next(1, 101);

            while (true) 
            {
                Console.WriteLine("Guess a number between 1-100");
                int numberUser = Convert.ToInt32(Console.ReadLine());
                if (numberUser > number)
                {
                    Console.WriteLine("My number is smaller");
                }
                else if (numberUser < number) 
                {
                    Console.WriteLine("My number is bigger");
                }
                else
                {
                    Console.WriteLine("Yeah! This is my number!");
                    break;
                }



            }

        }
    }
}
