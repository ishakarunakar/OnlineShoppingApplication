using System.Collections.Generic;
using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct=productCollection.Find(p=>true).Any();
            if(!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
			{
                new Product()
                {
			        Name = "Half Girlfriend",
			        Category = "Novels",
			        Description = "Description",
			        ImageFile = "ImageFile",
			        Price = 140
			    },

                new Product()
                {
			        Name = "Dr B.R Ambedkar Struggles And Message",
			        Category = "Biography",
			        Description = "Description",
			        ImageFile = "ImageFile",
			        Price = 599
			    },

                new Product()
                {
                    Name = "Harry Potter",
                    Category = "Adventure",
                    Description = "Description",
                    ImageFile = "ImageFile",
                    Price = 268
                }
            };
        }
    }
}