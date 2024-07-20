using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("Eripride", "164003349337", 20, 25);
        Product product1 = new Product("fresh fri", "161106610211", 45,18);
        Product product2 = new Product("Rayaan Ice", "792382613885", 15, 30);
        Product product3 = new Product("Geisha", "6166000141663", 12, 50);
        Product product4 = new Product("Delite Yoghurt", "161100460775", 9, 60);
        Product product5 = new Product("Monster Energy", "161101064644", 32, 40);

        Address address = new Address("132, My Street", "Kingston", "New York", "USA");
        Address address1 = new Address("118, Westlands Business Centre", "Westlands", "Nairobi", "Kenya");
      
        Customer customer1 = new Customer("Harvey Michael Ouma", address1);
        Customer customer2 = new Customer("Jurdine Ruth Peryl", address);
    
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(product);
        order1.AddProduct(product2);
        order1.AddProduct(product4);


        order2.AddProduct(product1);
        order2.AddProduct(product3);
        order2.AddProduct(product5);


        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Order 1 Total Price: ${order1.OrderPrice()}");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Order 2 Total Price: ${order2.OrderPrice()}");
        Console.WriteLine("---------------------------------------------");         
    }
}