class Ex9{
    static void Main(){

    Console.WriteLine("Enter the number of students");
 int num = int.Parse(Console.ReadLine());
       int maxScore=-1;
       String top ="";
       int secondMax=-1;       
       String top1 ="";
       int count=0;
        while (count < num)
        {   
                 Console.WriteLine("Enter the name of student");
                    String name = Console.ReadLine();
                     Console.WriteLine("Enter the scoer");
                     int score = int.Parse(Console.ReadLine());
                       if(score > maxScore)
            {
               secondMax = maxScore;
                top=top1;
                maxScore=score;
                top=name;
           
            }
       
            else if(score > secondMax)
            {
               secondMax=score;
               top1=name;
            }
                 count++;
        }
 Console.WriteLine("The max score is " +top);
 Console.WriteLine("The Second max score is " +top1);

    }}