public class Product
{
    private string _productName;
    private string _productId;
    private float _productPrice;
    private int _productQuantity;

    public Product(string productName, string productId, float productPrice, int productQuantity)
    {
        _productId = productId;
        _productName = productName;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public float GetProductPrice()
    {
        return _productPrice * _productQuantity;
    }

    public int GetProductQuantity()
    {
        return _productQuantity;
    }

    public string DisplayProductInformation()
    {
        return $"Name of Product: {_productName}\nProduct ID: {_productId}";
    }
}