namespace Foundation2 {
class Product
{
    private string _productName;
    private int _productID;
    private double _productPrice;
    private int _productQuantity;
    public Product(string productName, int productID, double productPrice, int productQuantity) {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public double GetProductTotalPrice() {
        return _productPrice * _productQuantity;
    }

    public string GetProductName() {
        return _productName;
    }

    public int GetProductID() {
        return _productID;
    }
}
}