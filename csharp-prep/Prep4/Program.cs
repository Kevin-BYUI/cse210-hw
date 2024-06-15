using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -2;
        while (userNumber != 0)
        {
            Console.Write("Enter number (0 to quit): ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;       
        }
        Console.WriteLine($"The sum is {sum}");
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is {average}");
        int max = 0;
         foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        }


    }
