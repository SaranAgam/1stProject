using System;

namespace _1stProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any 2 numbers from keyboard : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int key = num1 + num2;
            Console.WriteLine("The ascii key value is: " + key);
        }

    }
}
