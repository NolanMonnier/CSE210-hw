using System;
public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer = new Customer();
    private double _total = 0;

    public Order()
    {

    }

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public List<Product> AddToList(Product product)
    {
        _productList.Add(product);
        return _productList;
    }

    public double TotalCost()
    {
        foreach (Product product in _productList)
        {
            double _price = product.ProductPrice();
            _total += _price;
        }
        return Math.Round(_total, 2);
    }

    public void DisplayTotalCost(double total)
    {
        if (_customer.LiveinUSA() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        System.Console.WriteLine($"The total price for this order is {total.ToString("F2")}$.");
    }

    public void PackingLabel(Product product, int _productCount)
    {
        string name = product.GetName();
        int id = product.GetProductID();
        string packingLabel = _productCount.ToString() + ". " + name + ": " + id.ToString();
        System.Console.WriteLine(packingLabel);
    }

    public void ShippingLabel(Customer customer, Address address)
    {
        string name = customer.GetName();
        string fullAddress = address.FullAddress();
        string shippingLabel = name + "\n" + fullAddress;
        System.Console.WriteLine("Shipping Label:");
        System.Console.WriteLine(shippingLabel);
    }
}