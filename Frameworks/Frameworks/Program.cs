using Frameworks.Entities;
using Frameworks.Persistence;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Xml.Linq;

DataMasterDbContext _productContext = new();
_productContext.Products.Add(new("Laptop", 999.99));
_productContext.Products.Add(new("Smartphone", 599.99));
_productContext.Products.Add(new("Tablet", 349.99));
List<Product> products = _productContext.Products.ToList();

Product productToUpdate = _productContext.Products.FirstOrDefault(p => p.Name == "Smartphone");

if (productToUpdate != null)//Update
{
    productToUpdate.Price = 649.99; 
    _productContext.SaveChanges();
}

foreach (Product product in products)
{
    Console.WriteLine(product.Price);
}


List<Product> newProducts = new List<Product>//Add
{
    new Product ( "Desktop", 1299.99 ),
    new Product ( "Monitor", 299.99 ),
    new Product ( "Keyboard", 49.99 )
};




