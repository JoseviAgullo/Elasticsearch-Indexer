using System.Collections.Generic;
using ElasticsearchIndexer.Models;

namespace ElasticsearchIndexer.Infrastructure.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
    }
}