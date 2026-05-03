using System;

class Ex27
{
    static void Main()
    {
        int count = 0;

        for (int y = 2001; y <= 2100; y++){        
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.Write(y + " ");
                count++;
                if (count % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}