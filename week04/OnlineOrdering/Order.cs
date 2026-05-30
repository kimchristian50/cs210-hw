using System;

public class Order
{
    // attributes
    private List<Product> _products;
    private Customer _customer;

    // constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>(); // Initializes an empty box to hold products
    }

    // method
    public string GetShippingLabel()
    {
        return $"{_customer.GetDisplayText()}";
    }

    public int GetShippingCost()
    {
        int shipping;
        if (_customer.IsCountryUsa() == true)
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return shipping;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalOrderCost()
    {
        double orderTotal = 0;
        foreach (Product currentProduct in _products)
        {
            orderTotal = orderTotal + currentProduct.GetTotal();
        }
        return orderTotal;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label\n";
        foreach (Product currentProduct in _products)
        {
            label += $"- {currentProduct.GetProductName()} (ID: {currentProduct.GetProductId()})\n";
        }
        label += $"Product total: ${CalculateTotalOrderCost():F2}\n";
        label += $"Shipping cost: ${GetShippingCost():F2}\n";
        label += $"Order total: ${CalculateTotalOrderCost() + GetShippingCost():F2}\n";

        return label;
    }

    public string GetDisplayText()
    {
        string text = "========================================\n";
        text += GetPackingLabel();
        text += "========================================\n";
        text += $"Shipping label:\n{_customer.GetDisplayText()}\n";
        return text;
    }
}