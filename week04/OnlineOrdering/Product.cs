public class Product
{
    private String _name;
    private int _productID;
    private float _price;
    private int _quantity;

    public Product(String name, int id, float price)
    {
        _name = name;
        _productID = id;
        _price = price;
    }
    public Product(String name, int id, float price, int quantity)
    {
        _name = name;
        _productID = id;
        _price = price;
        _quantity = quantity;        
    }

    public float CalculateTotalCost()
    {
        float cost = _price * (float)_quantity;

        return cost;
    }
    public String GetName()
    {
        return _name;
    }
    public void SetName(String name)
    {
        _name = name;
    }
    public int GetProductID()
    {
        return _productID;
    }
    public void setProductID(int productID)
    {
        _productID = productID;
    }
    public float GetPrice()
    {
        return _price;
    }
    public void SetPrice(float price)
    {
        _price = price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}