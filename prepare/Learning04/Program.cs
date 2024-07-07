using System;

class Program
{
    static void Main(string[] args)
    {
       Assignment assignment = new Assignment("Samwel Bennet", "Multiplication");
       MathAssignment mathAssignment = new MathAssignment("Kevin Ogutu", "Fractions", "7.3", "8-19");
       WritingAssignment writingAssignment = new WritingAssignment("Harvey Michael", "Poetry", "The Fall Of Zebul's Kingdom");
       Console.WriteLine(writingAssignment.GetWritingInfo());
     
       
       


    }
}