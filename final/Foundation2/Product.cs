using System;

public class Product
{
    private string _name {get; set;}
    private string _id {get; set;}
    private  double _price {get; set;}
    private int _quantity {get; set;}

    public Product (string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double CalculatePrice()
    {
        return Math.Round((_price * _quantity),2);
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"{_name} ({_id}) => Total: ${CalculatePrice()}");
    }
}