using System.Numerics;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public float OrderPrice()
    {
        float total = 0;
        foreach (Product product in _products) 
        {  
           total += product.GetProductPrice();
        }
        if (_customer.CountryOfResidence() == "USA")
        {
            total += 5;
        }
        else
        {
            total += 35;
        } 
        return total;    
    }

    public string GetShippingLabel()
    {
        return _customer.DisplayCustomerInformation();
    }

    public string GetPackingLabel()
    {
        System.Text.StringBuilder packingLabel = new System.Text.StringBuilder();
        foreach (Product product in _products)
        {
            packingLabel.AppendLine($"Product Name: {product.GetProductName()}, Product ID: {product.GetProductId()}");
        }
        return packingLabel.ToString();
    } 

    


}