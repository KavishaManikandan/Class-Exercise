using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the first number:");
       int a = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("Enter the second number:");
       int b = Convert.ToInt32(Console.ReadLine());

       int c = a + b;
       Console.Write("The sum is: " + c);
    }
}