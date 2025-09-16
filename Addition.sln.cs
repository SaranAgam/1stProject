using System;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("Enter the numbers: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());
		int sum = num1 + num2;
		Console.WriteLine("The sum of two numbers is: " + sum);
    }
}
