using System;
class Ex1{
static void Main(){
   Console.WriteLine("Enter an integer,");
        String input = Console.ReadLine();
        int num = int.Parse(input);
        int pos =0;
        int neg=0;
        int count=0;
        double sum = 0;
        while (num != 0)
        {
            if (num > 0)
            {
                pos++;
            }
            else{neg++;}
            sum+=num;
            count++;
            
            Console.Write("Enter next number: ");
            num = int.Parse(Console.ReadLine());;
        }
        if (count == 0)
        {
            Console.WriteLine("No numbers are entered except 0");
        }
        else
        {
            double averge= sum/count;
            Console.WriteLine("The number is positive" +pos);
            Console.WriteLine("The number is negative" +neg);
            Console.WriteLine("The total is " + sum);
          Console.WriteLine("The average is " + averge);
        }
}
}