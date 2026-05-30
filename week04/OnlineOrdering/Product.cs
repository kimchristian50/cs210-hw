using System;
using System.Numerics;

public class Product
{
    // attributes
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    // constructor
    // name id # price, quantity
    public Product(string productName, int productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // methods
    public double GetTotal()
    {
        double total = _price * _quantity;
        return total;
    }

    public string GetDisplayText()
    {
        string totalProduct = $"{_productName} (#{_productId}): {_quantity} at ${_price} each - Total: ${GetTotal()}";
        return totalProduct;
    }
    // Getter to safely share the product name with the Order class
    public string GetProductName()
    {
        return _productName;
    }

    // Getter to safely share the product ID with the Order class
    public int GetProductId()
    {
        return _productId;
    }
}