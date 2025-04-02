using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address landonAddress = new Address("5000N 5000W", "Rexburg", "ID", "USA");
        Customer landon = new Customer("Landon Searle", landonAddress);

        Address jennyAddress = new Address("5000N 5000W", "Ogden", "UT", "NOTUSA");
        Customer jenny = new Customer("Jenny Jacobson", jennyAddress);

        Product cheese = new Product("Miles Cheese", 5582, 10.69);
        Product fish = new Product("Fishy Fish", 1582, 0.69);
        Product milk = new Product("Warm Milk", 51, 5.99);
        Product apple = new Product("Moldy Apple", 8, 1.69);
        
        Order order1 = new Order(landon);
        order1.AddProduct(apple, 3);
        order1.AddProduct(fish, 6);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.CalculateTotalCost());


        Order order2 = new Order(jenny);
        order2.AddProduct(milk, 10);
        order2.AddProduct(apple, 3);
        order2.AddProduct(cheese, 15);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.CalculateTotalCost());
    }
}