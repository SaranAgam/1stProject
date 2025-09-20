using System;

namespace _1stProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any 2 numbers from keyboard : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            double quotient = num1 / num2;
            Console.WriteLine("The sum of 2 numbers is: " + sum);
            Console.WriteLine("The difference of 2 numbers is: " + difference);
            Console.WriteLine("The product of 2 numbers is: " + product);
            Console.WriteLine("The quotient of 2 numbers is: " + quotient);
        }

    }
}
