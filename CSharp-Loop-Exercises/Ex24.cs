using System;

class Ex24
{
    static void Main()
    {
        double sum = 0;

        for (double i = 1; i <= 97; i += 2)
        {
            sum += i / (i + 2);
        }

        Console.WriteLine("Sum of series: " + sum);
    }
}