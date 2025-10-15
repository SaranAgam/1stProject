using System;

namespace _1stProject
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter any 2 numbers from keyboard: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1+num2;
            double difference = num1-num2;
            double product = num1*num2;
            double quotient = num1/num2;
            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Difference : " + difference);
            Console.WriteLine("Product : " + product);
            Console.WriteLine("Quotient of: " + quotient);
        }

    }
}
