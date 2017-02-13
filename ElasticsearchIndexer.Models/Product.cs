using System.Collections.Generic;

namespace ElasticsearchIndexer.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<string> Keywords { get; set; }

        public double Price { get; set; }
    }
}
