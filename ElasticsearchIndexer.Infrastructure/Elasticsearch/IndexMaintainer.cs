using Nest;

namespace ElasticsearchIndexer.Infrastructure.Elasticsearch
{
    public class IndexMaintainer
    {
        private readonly IElasticClient _elasticsearchCustomClient;

        public IndexMaintainer(IElasticsearchClientFactory elasticsearchCustomClient)
        {
            _elasticsearchCustomClient = elasticsearchCustomClient.GetElasticClient();
        }

        public virtual bool IndexExists(string indexName)
        {
            return _elasticsearchCustomClient.IndexExists(indexName).Exists;
        }

        public virtual bool DeleteIndex(string indexName)
        {
            return _elasticsearchCustomClient.DeleteIndex(indexName).Acknowledged;
        }
    }
}
