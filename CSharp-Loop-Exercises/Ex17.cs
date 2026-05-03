using System;

class Ex17
{
    static void Main()
    {
        Console.WriteLine("Enter the number");
        int num = int.Parse(Console.ReadLine());
        for(int i =1; i<=num; i++)
        {
            for(int s =1; s<(num-i); s++)
            {
                Console.Write(" ");

            }
            for(int j =i; j>=1 ;j--)
            {
                Console.Write(j+" ");
            }
            for(int k =2; k<=i; k++)
            {
                Console.Write(k+" ");
            }
        Console.WriteLine();
        }
    }
}