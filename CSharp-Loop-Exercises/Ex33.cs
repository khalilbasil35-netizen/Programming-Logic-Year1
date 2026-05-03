using System;

class Ex33
{
    static void Main()
    {
        for (int number = 2; number < 10000; number++)
        {
            int sum = 0;
            for (int divisor = 1; divisor <= number / 2; divisor++)
            {
                if (number % divisor == 0)
                {
                    sum += divisor;
                }
            }
            if (sum == number)
            {
                Console.WriteLine(number);
            }
        }
    }
}