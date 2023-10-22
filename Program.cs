using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Invalid number.");
            }
            else
            {
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine($"Square root of {number} is: {squareRoot}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number.");
        }
        finally
        {
            Console.WriteLine("Good Bye.");
            
        }
    }
}
