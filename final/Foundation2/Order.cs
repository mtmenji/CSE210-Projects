namespace Foundation2 {
class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;
    private double _totalCost = 0;

    public Order(List<Product> productList, Customer customer) {
        _productList = productList;
        _customer = customer;
    }

    public double TotalCost() {
        foreach (var product in _productList) {
            _totalCost += product.GetProductTotalPrice();
        }
        if (_customer.IsCustomerUSA()) {
            return _totalCost += 5;
        } else {return _totalCost += 35;}
    }

    public void GetPackingLabel() {
        Console.WriteLine("Packing Label");
        Console.WriteLine("----------------------------------------------");
        foreach (var product in _productList) {
            string _productName = product.GetProductName();
            int _productID = product.GetProductID();
            Console.WriteLine("Product Name: " + product.GetProductName() + "\tProduct ID: " + product.GetProductID() + "\n");
        }
    }

    public void GetShippingLabel() {
        Console.WriteLine("Shipping Label");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Name: " + _customer.GetCustomerName() + "\tAddress: " + _customer.GetFullAddress());
    }
}
}