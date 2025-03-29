
using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("---------------------------------------------");
        Address address1 = new Address ("33 Nice Ave.", "Sacramento", "CA", "USA");
        Customer customer1 = new Customer("Nathan Jackson", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Pear", "2345", 0.35, 6);
        Product order1Product2 = new Product("Avocado", "2412", 1.15, 4);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        order1.DisplayShippingLabel(); 
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal ,order1ShippingCost, order1Total);


        Console.WriteLine("---------------------------------------------");


        Address address2 = new Address ("Kreftings Gate", "Dramman", "Drammen", "Norway");
        Customer customer2 = new Customer("Amund Hansen", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Coconut", "2780", 3.10, 8);
        Product order2Product2 = new Product("Bell pepper", "2987", 0.90, 3);
        Product order2Product3 = new Product("Pineapple", "2543", 2.35, 4);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();


        order2.DisplayShippingLabel(); 
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
        Console.WriteLine("---------------------------------------------");

    }   
}
