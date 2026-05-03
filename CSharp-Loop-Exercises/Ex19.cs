using System;

class Ex19
{
    static void Main()
    {
        int num=8; 
        for (int i=0; i<num; i++)
        {
            for (int s=1; s<(num - i); s++)
            {
                Console.Write("    "); 
            }
            for (int j =0; j<= i; j++)
            {
                Console.Write(Math.Pow(2, j) + "   "); 
            }

            for (int k =i - 1; k>= 0; k--)
            {
                Console.Write(Math.Pow(2, k) + "   ");
            }

            Console.WriteLine();
        }
    }
}