using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number(integer): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int copy  = n;
            int sum   = 0;
            int count = 0;
            while (copy != 0)
            {
                copy /= 10;
                count++;
            }
            bool skip = (count % 2 == 0) ? true : false;
            while(n != 0)
            {
                int digit = n % 10;
                n /= 10;
                if (skip) { skip = false; continue; }
                sum += digit;
                skip = true;
            }
            Console.WriteLine("Sum of the digits you entered is: " + sum);
            Console.WriteLine("Thank you.");
        }
    }
}
