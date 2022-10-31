

using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variable (faruqesay)
            int n;

            //take input (faruqesay)
            Console.Write("Enter the number = ");
            n = Convert.ToInt32(Console.ReadLine());

            //check if n is even or odd (faruqesay)
            if (n % 2 == 0)
                Console.WriteLine(n + " is even");
            else
                Console.WriteLine(n + " is odd");

            // wait for user to press any key (faruqesay)
            Console.ReadKey();
        }
    }
}







