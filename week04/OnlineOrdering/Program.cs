using System;

class Program
{
    static void Main(string[] args)
    {
        // create the product library
        Product gumdrops = new Product("Spice drops", 100035, 1.95, 5);
        Product peachRings = new Product("Fruity peach rings", 100036, 2.95, 2);
        Product hiChew = new Product("Hi Chews", 100037, 5.95, 1);
        Product doveDark = new Product("Dark chocolate Dove pieces", 100040, 6.50, 1);
        Product doveMilk = new Product("Milk Chocolate Dove pieces", 100041, 6.50, 1);
        Product mikeike = new Product("Mike and Ikes", 100038, 1.45, 1);
        Product yogurtFruit = new Product("Yogurt covered dried berries", 100039, 6.75, 1);
        Product gushers = new Product("Mixed fruit gushers", 100033, 3.95, 2);
        Product sunchips = new Product("Original flavor Sunchips", 10099, 3.5, 1);
        Product mnms = new Product("Mini M&Ms", 100029, 2.95, 2);

        // create the new address for order #1
        Address pamsAddress = new Address("6121 Sierra Linda Ave NW", "Albuquerque", "NM", "USA");

        // create the new customer for order #1
        Customer pamsCustomer = new Customer("Pam Christison", pamsAddress);

        // create order #1
        Order pamsOrder = new Order(pamsCustomer);
        pamsOrder.AddProduct(doveMilk);
        pamsOrder.AddProduct(doveDark);
        pamsOrder.AddProduct(yogurtFruit);
        pamsOrder.AddProduct(gumdrops);

        // create order #2
        Address intlAddress = new Address("123 Maple Street", "Toronto", "ON", "Canada");
        Customer intlCustomer = new Customer("Mark Carney", intlAddress);
        Order order2 = new Order(intlCustomer);
        order2.AddProduct(peachRings);
        order2.AddProduct(sunchips);
        order2.AddProduct(gushers);

        Console.WriteLine(pamsOrder.GetDisplayText());

        Console.WriteLine(order2.GetDisplayText());
    }
}