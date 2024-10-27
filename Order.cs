using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal TotalPrice => Price * Quantity;
}

public class Order
{
    public int Id { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();

    public decimal TotalPrice => Products.Sum(p => p.TotalPrice);

    public void AddProduct(Product product)
    {
        var existingProduct = Products.FirstOrDefault(p => p.Name == product.Name);
        if (existingProduct != null)
        {
            existingProduct.Quantity += product.Quantity;
        }
        else
        {
            Products.Add(product);
        }
    }
}
