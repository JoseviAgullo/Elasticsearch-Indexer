using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElasticsearchIndexer.Models;
using Nest;

namespace ElasticsearchIndexer.Infrastructure.Elasticsearch
{
    public class IndexMaintainer : IIndexMaintainer
    {
        private readonly IElasticClient _elasticsearchClient;

        public IndexMaintainer(IElasticsearchClientFactory elasticsearchCustomClient)
        {
            _elasticsearchClient = elasticsearchCustomClient.GetElasticClient();
        }

        public virtual bool IndexExists(string indexName)
        {
            return _elasticsearchClient.IndexExists(indexName).Exists;
        }

        public virtual bool DeleteIndex(string indexName)
        {
            return _elasticsearchClient.DeleteIndex(indexName).Acknowledged;
        }

        public void CreateIndex(string newIndexName)
        {
            _elasticsearchClient.CreateIndex(newIndexName,
                i => i
                    .Mappings(ms => ms
                        .Map<Product>(m => m.AutoMap())));
        }

        public bool IndexContainsDocuments(string indexName)
        {
            return _elasticsearchClient.Search<dynamic>(s => s.Index(indexName).AllTypes().From(0).Size(10).MatchAll()).Documents.Any();
        }

        public IEnumerable<Task<IBulkResponse>> IndexProducts(string indexName, List<Product> products)
        {
            var bulkProviderLocation = new BulkProviderClient(indexName, _elasticsearchClient);

            foreach (var product in products)
            {
                bulkProviderLocation.Create<Product>(c => c.Document(product));
            }

            return bulkProviderLocation.GetTasks();
        }
    }
}
