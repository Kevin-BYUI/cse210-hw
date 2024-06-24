using System;
using System.Runtime.InteropServices.Marshalling;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
public class Program
{
    public static void Main(string[] args)
    {
        DisplayMessage();
        ShoppingCart();
    }
    
    public static void ShoppingCart()
    {
        
        List<float>prices = new List<float>();
        List<string>cart = new List<string>();
        string start = "YES";
        while (start.ToUpper() == "YES")
        {
            Console.WriteLine("Please enter one of the following:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. View Cart");
            Console.WriteLine("3. Remove Item");
            Console.WriteLine("4. Compute Total");
            Console.WriteLine("5. Quit");
            Console.Write("Please enter an action: ");
            int action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                Console.Write("What item would you like to add? ");
                string answer = Console.ReadLine();
                cart.Add(answer);
                Console.Write($"What is the price of {answer}? ");
                float price = float.Parse(Console.ReadLine());
                prices.Add(price);
                Console.WriteLine($"'{answer}' of {price} has been added to the cart\n");

            }
            else if (action == 2)
            {
                Console.WriteLine("The items of the shopping cart are:");
                for (int i = 0; i < cart.Count; i ++)
                {
                    string item = cart[i];
                    float price = prices[i];
                    Console.WriteLine($"{i + 1}.{item} - ${price}");     
                }
            }
            else if (action == 3)
            {
                Console.Write("What item do you want to remove? ");
                int item = int.Parse(Console.ReadLine());
                cart.RemoveAt(item);
                prices.RemoveAt(item);
                Console.WriteLine("Item removed");
            }
            else if (action == 4)
            {
                float total = 0;
                foreach (float i in prices)
                {
                    total += i;
                }
                Console.WriteLine($"The total is {total}");

            }

        }

    }
    public static void DisplayMessage()
    {
        Console.WriteLine("\nWelcome to the shopping cart program!\n");
    }
}