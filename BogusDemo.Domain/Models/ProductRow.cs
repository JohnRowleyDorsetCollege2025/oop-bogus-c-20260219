using System;
using System.Collections.Generic;
using System.Text;

namespace BogusDemo.Domain.Models
{
    public class ProductRow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public int Stock { get; set; } = 0;
    }
}

// Repeat for product what we did for people,
// create a ProductRow class with properties Id, Name, Price, Category and a private Stock property.
// Then, in the FakeDataService, create a method GenerateFakeProducts(int count)
// that generates a list of ProductRow objects with fake data using the Bogus library.
// Finally, create a ProductsController in the MVC project that uses the FakeDataService
// to generate a list of products and pass it to a view for display, adding it to the nav menu n
