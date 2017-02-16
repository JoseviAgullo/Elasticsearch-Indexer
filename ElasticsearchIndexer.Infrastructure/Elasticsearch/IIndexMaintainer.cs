using System.Collections.Generic;
using System.Threading.Tasks;
using ElasticsearchIndexer.Models;
using Nest;

namespace ElasticsearchIndexer.Infrastructure.Elasticsearch
{
    public interface IIndexMaintainer
    {
        bool DeleteIndex(string indexName);
        bool IndexExists(string indexName);
        void CreateIndex(string newIndexName);
        bool IndexContainsDocuments(string indexName);
        IEnumerable<Task<IBulkResponse>> IndexProducts(string indexName, List<Product> products);
    }
}