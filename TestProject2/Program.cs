using System;

namespace TestProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles = 0;
            int gallons = 0;
            int mpg = 0;
            Console.WriteLine("Hello World!");
            Console.Write("Miles Travelled");
            String temp = Console.ReadLine();
            miles = int.Parse(temp);
            Console.WriteLine();
            Console.Write("Gallons used:");
            temp = Console.ReadLine();
            gallons = int.Parse(temp);
            mpg = miles / gallons;
            Console.WriteLine("You got " + mpg + " Miles per gallon");
        }
    }
}
