using Frameworks.Entities;
using Frameworks.Persistence;
using Microsoft.EntityFrameworkCore;

DataMasterDbContext _productContext = new();

var category = new Category()
{
    Id = 1,
    Name = "Devices"
};

var category2 = new Category()
{
    Id = 2,
    Name = "Book"
};


_productContext.Products.Add(new("Laptop", 999, category));
_productContext.Products.Add(new("Tablet", 569, category));
_productContext.Products.Add(new("Book1",69, category2));
_productContext.Products.Add(new("Book2", 89, category2));

//insertion
_productContext.Products.AddRange(new List<Product>
{
    new Product ("Smartphone", 459, category),
    new Product ("Nintendo", 399, category),
    new Product ("Book3", 39, category2),
    new Product ("Book4", 49, category2),
});

_productContext.SaveChanges();

//remove
_productContext.Products.RemoveRange(_productContext.Products.Where(x => x.Name == "Laptop"));

_productContext.SaveChanges();


//update
var product = _productContext.Products.First();
product.Name = "Nintendo";


List<Product> products = _productContext.Products.ToList();



Console.WriteLine(products);
Console.ReadLine();



/*_productContext.Products.Add(new("Laptop", 999.99));
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
};*/