using System;
using System.Runtime.ExceptionServices;

class Perfect
{
    public static void Main(string[] args)
    {
        int number, i, sum;
        while (true)

        {


            Console.WriteLine("Enter a number to evaluate if it is perfect or type exit to quit out: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            if (int.TryParse(input, out number))
            {

                sum = 0;

                for (i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }

                }
                if (sum == number)
                    Console.WriteLine("Perfect Number\n");
                else
                    Console.WriteLine("Not A Perfect Number\n");

            }
        }
    }
}