using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> _productList = new List<Product>();
        double _total = 0;
        int _productCount = 1;

        Console.Clear();
        System.Console.WriteLine("First Order:");
        Product product = new Product();
        Product product1_1 = new Product("Milk", 12345, 5.50, 1);
        Product product1_2 = new Product("Bread", 24095, 2.35, 2);
        Product product1_3 = new Product("Eggs", 43083, 1.95, 3);
        Address address1 = new Address("415W 6S", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("Addison Prince", address1);
        Order order1 = new Order(customer1);
        _productList = order1.AddToList(product1_1);
        _productList = order1.AddToList(product1_2);
        _productList = order1.AddToList(product1_3);
        System.Console.WriteLine("Packing Label:");
        foreach (Product line in _productList)
        {
            order1.PackingLabel(line, _productCount);
            _productCount++;
        }
        System.Console.WriteLine();
        order1.ShippingLabel(customer1, address1);
        System.Console.WriteLine();
        _total += order1.TotalCost();
        order1.DisplayTotalCost(_total);
        _productList.Clear();
        System.Console.WriteLine();
        System.Console.WriteLine();
        _productCount = 1;


        System.Console.WriteLine("Second Order:");
        Product product2_1 = new Product("Onions", 28374, 1.15, 4);
        Product product2_2 = new Product("Cheese", 93847, 6.00, 1);
        Product product2_3 = new Product("Ground Beef", 93847, 17.35, 1);
        Product product2_4 = new Product("Spaghetti", 84756, 1.70, 2);
        Address address2 = new Address("Grand'Rue 6", "Le Sentier", "Vaud", "Switzerland");
        Customer customer2 = new Customer("Nolan Monnier", address2);
        Order order2 = new Order(customer2);
        _productList = order2.AddToList(product2_1);
        _productList = order2.AddToList(product2_2);
        _productList = order2.AddToList(product2_3);
        _productList = order2.AddToList(product2_4);
        System.Console.WriteLine("Packing Label:");
        foreach (Product line in _productList)
        {
            order2.PackingLabel(line, _productCount);
            _productCount++;
        }
        System.Console.WriteLine();
        order2.ShippingLabel(customer2, address2);
        System.Console.WriteLine();
        _total += order2.TotalCost();
        order2.DisplayTotalCost(_total);
    }
}