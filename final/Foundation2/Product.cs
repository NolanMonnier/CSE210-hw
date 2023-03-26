using System;
public class Product
{
    private string _name = "";
    private int _productID = 0;
    private double _price = 0;
    private double _totalProductPrice = 0;
    private double _quantity = 0;

    public Product()
    {

    }

    public Product(string name, int productID, double price, double quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public double GetPrice()
    {
        return _totalProductPrice;
    }

    public double ProductPrice()
    {
        _totalProductPrice = _price * _quantity;
        return _totalProductPrice;
    }
}