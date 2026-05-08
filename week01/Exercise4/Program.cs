using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int numberAdd = -1;

        while (numberAdd != 0)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            numberAdd = int.Parse(number);

            if (numberAdd != 0)
            {
                numbers.Add(numberAdd);
            }

        }

        int count = numbers.Count();

        // these calculations only work if the first number wasn't a 0
        if (count != 0)
        {
            int total = numbers.Sum();
            Console.WriteLine($"The sum is: {total}");
            double average = numbers.Average();
            Console.WriteLine($"The average is: {average}");
            int maxVal = numbers.Max();
            Console.WriteLine($"The largest number is: {maxVal}");
            int smallestPositive = numbers.Where(n => n > 0).Min();
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            Console.WriteLine("The sorted list is: ");
            foreach (int n in numbers.OrderBy(n => n))
            {
                Console.WriteLine(n);
            }
        }

    }
}