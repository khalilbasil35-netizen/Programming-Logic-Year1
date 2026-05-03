using System;

class Ex41
{
    static void Main()
    {
        Console.WriteLine("Enter numbers (0 to end):");
        
        int max = 0;
        int count = 0;
        int number;

        while (true)
        {
            number = int.Parse(Console.ReadLine());

            if (number == 0) break;

            if (number > max)
            {
                max = number;
                count = 1;
            }
            else if (number == max)
            {
                count++;
            }
        }

        if (max != 0)
        {
            Console.WriteLine("The largest number is " + max);
            Console.WriteLine("The occurrence count of the largest number is " + count);
        }
    }
}