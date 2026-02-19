using BogusDemo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BogusDemo.Domain.Services
{
    public class FakeDataService
    {
        public FakeDataService()
        {

        }

        public static List<PersonRow> GenerateFakePeople(int count)
        {

            var faker = new Bogus.Faker<PersonRow>()
                .RuleFor(p => p.Id, f => f.IndexFaker + 1)
                .RuleFor(p => p.FullName, f => f.Name.FullName())
                .RuleFor(p => p.Email, f => f.Internet.Email())
                .RuleFor(p => p.City, f => f.Address.City())
                .RuleFor(p => p.DateOfBirth, f => f.Date.Past(50, DateTime.Now.AddYears(-18)));

            return faker.Generate(count);

        }

        public static List<ProductRow> GenerateFakeProducts(int count)
        {
            var products = new List<ProductRow>();


            var faker = new Bogus.Faker<ProductRow>()
                .RuleFor(p => p.Id, f => f.IndexFaker + 1)
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
             
                .RuleFor(p => p.Category, f => f.Commerce.Categories(1).First())

                .RuleFor(p => p.Price, f => decimal.Parse(f.Commerce.Price()))

                .RuleFor(p => p.Stock, f => f.Random.Int(0, 1000));

            return faker.Generate(count);
        }
    }
}
