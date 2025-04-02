public class Order
{
    List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order( Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product, int quantity)
    {
        product.SetQuantity(quantity);
        _products.Add(product);
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public double CalculateTotalCost()
    {
        // Calculate shippping cost
        double shipppingCost;
        if (_customer.LivesInUSA())
        {
            shipppingCost = 5;
        }
        else
        {
            shipppingCost = 35;
        }


        // Calcualte total cost including shippingcost
        double totalCost = shipppingCost;
        foreach(Product product in _products)
        {
            totalCost += product.CalculateTotalCost();
        }
        return totalCost;
    }

    public String GetPackingLabel()
    {
        String label = $"Customer: {_customer.GetName()}\n\n";
        label += $"Products\n";

// This will create a list of pruducts and its prices
        foreach(Product product in _products)
        {
            int nameLength = product.GetName().Length;
            int priceLength = product.GetPrice().ToString().Length;
            int IDLength = product.GetProductID().ToString().Length;
            label += $"[{product.GetProductID()}]{product.GetName()} X{product.GetQuantity()}";
            for(int i = nameLength + priceLength + IDLength; i < 30; i++)
            {
                label += ".";
            }
            label += $"#{product.GetPrice()}\n";
        }

        return label;
    }

    public String GetShippingLabel()
    {
        String label = $"{_customer.GetName()}\n";
        label += $"{_customer.GetAddress().DisplayAll()}\n";

        return label;
    }
}