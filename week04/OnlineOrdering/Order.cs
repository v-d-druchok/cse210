public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double Total()
    {   
        double total = 0;

        foreach(Product product in _products)
        {
            total += product.ProductCost();
        }

        if (_customer.UsResident())
        {
            total += 5;
        }
        else 
        {
            total += 35;
        }

        return Math.Round(total, 2);
    }

    public string MakePackingLabel()
    {   
        string packingLabel = "";

        foreach(Product product in _products)
        {
            packingLabel += $"{product.GetName()}, {product.GetId()}\n";
        }

        return packingLabel;
    }

    public string  MakeShippingLabel()
    {
        return $"{_customer.GetName()},\n{_customer.GetAddress().FullAddress()}";
    }
}