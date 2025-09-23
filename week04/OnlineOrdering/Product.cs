using System;

class Product
{
    private int _productId;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(int productId, string name, double price, int quantity)
    {
        _productId = productId;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetPrice()
    {
        return _price;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }
}
