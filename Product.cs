using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping_cart;
public class Product
{
    public  Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set;}

    public Product (string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public override string ToString()
    {
        return $"{Id} {Name} {Description} {Price}";
    }
}
