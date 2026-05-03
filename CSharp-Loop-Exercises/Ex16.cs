class Ex16{
    static void Main()
    {
            Console.WriteLine("Enter the number :");
      int num = int.Parse(Console.ReadLine());
      int i=2;
      while (num > 1)
      {
         if(num % i == 0)
         {
            Console.WriteLine(i);
            num/=i;
         }
         else {i++;}
    }
    }}