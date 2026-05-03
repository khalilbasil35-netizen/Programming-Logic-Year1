class Ex8
{
    static void Main()
    {
  
    Console.WriteLine("Enter the number of students");
 int num = int.Parse(Console.ReadLine());
       int maxScore=-1;
       String top ="";
       int count=0;
        while (count < num)
        {   
                 Console.WriteLine("Enter the name of student");
                    String name = Console.ReadLine();
                             Console.WriteLine("Enter the scoer");
                     int score = int.Parse(Console.ReadLine());
                       if(score > maxScore)
            {
               maxScore = score;
                top=name;
            }
            count++;
           
        }
 Console.WriteLine("The max score is " +top);
}}