using System.Collections.Generic;
using ElasticsearchIndexer.Models;

namespace ElasticsearchIndexer.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Bicicleta de carrera",
                    Description = "Una bicicleta de carreras muy versátil y cómoda",
                    Keywords = new List<string> { "bicicleta", "carrera", "carretera" },
                    Price = 10
                },
                new Product
                {
                    Id = 2,
                    Name = "Bicicleta de montaña",
                    Description = "Bicicleta preparada para los terrenos más complicados",
                    Keywords =
                        new List<string> { "bicicleta", "montaña", "mountain", "bike", "mountainbike", "mountain-bike" },
                    Price = 20
                },
                new Product
                {
                    Id = 3,
                    Name = "Carrito de bebé",
                    Description = "Carrito con el cual sacar a pasear a tu bebé",
                    Keywords = new List<string> { "bebé", "carrito", "carricoche", "paseo" },
                    Price = 30
                },
                new Product
                {
                    Id = 4,
                    Name = "Muñeca bebé",
                    Description = "Una muñeca que representa fielmente un bebé",
                    Keywords = new List<string> { "muñeca", "bebé" },
                    Price = 40
                },
                new Product
                {
                    Id = 1,
                    Name = "Bicicleta ciudad",
                    Description = "Bicicleta orientada al paseo por la ciudad",
                    Keywords = new List<string> { "bicicleta", "paseo", "ciudad" },
                    Price = 50
                }
            };
        }
    }
}
