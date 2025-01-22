
public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

public Product(string name, decimal price, int quantity)
{
    this.Name = name;
    this.Price = price;
    this.Quantity = quantity;
}

    public abstract void DisplayInfo(); //abstract method, so every dependant class can use it as they have to.

}

