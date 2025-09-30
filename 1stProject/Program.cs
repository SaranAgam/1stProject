using System;

namespace _1stProject
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter any 2 numbers from keyboard: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1+num2;
            double difference = num1-num2;
            double product = num1*num2;
            double quotient = num1/num2;
            Console.WriteLine("The sum of given 2 numbers is: " + sum);
            Console.WriteLine("The difference of given 2 numbers: " + difference);
            Console.WriteLine("The product of given 2 numbers: " + product);
            Console.WriteLine("The quotient of given 2 numbers: " + quotient);
        }

    }
}
