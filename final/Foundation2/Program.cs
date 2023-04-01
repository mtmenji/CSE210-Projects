using System;

namespace Foundation2 {
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("366 Wagon Trail", "Willow Springs", "NC", "USA");
        Customer customer1 = new Customer("Michael Menjivar", address1);
        
        List<Product> productList1 = new List<Product>();
        Product product1 = new Product("product1", 1001, 2.55, 2);
        productList1.Add(product1);
        Product product2 = new Product("product2", 1002, 5.75, 5);
        productList1.Add(product2);
        Product product3 = new Product("product3", 1003, 1.70, 10);
        productList1.Add(product3);

        Order order1 = new Order(productList1, customer1);
        order1.GetPackingLabel();
        order1.GetShippingLabel();
        Console.WriteLine("The total cost is: $" + order1.TotalCost());
    }
}
}