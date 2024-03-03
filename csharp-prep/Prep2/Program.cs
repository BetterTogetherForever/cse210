using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Please inform your grade percentage:");
       String grade = Console.ReadLine();
       int percent = int.Parse(grade);
       String status;
       String letter;
       String signal;

       if (percent >= 90)
       {
         letter = "A";
       }
       else if (percent >= 80)
       {
         letter = "B";
       }
       else if (percent >= 70)
       {
         letter = "C";
       }
       else if (percent >= 60)
       {
         letter = "D";
       }
       else
       {
         letter = "F";
       }
       
       
       if (percent >=70)
       {
        status = "You Passed!";
       }
       else
       {
        status = "You failed. Better luck next time";
       }

       if (percent % 10 >=7 && letter !="A" && letter != "F")
       {
          signal = "+";
       }
       else if (percent % 10 <3 && letter != "F")
       {  
          signal = "-" ;
       }
       else
       {
         signal = "";
       }
       Console.WriteLine($"Your Score is {letter}{signal}, {status}");
       
    }
}