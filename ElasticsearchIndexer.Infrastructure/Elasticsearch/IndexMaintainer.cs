namespace ElasticsearchIndexer.Infrastructure.Elasticsearch
{
    public class IndexMaintainer
    {
        private readonly IElasticsearchCustomClient _elasticsearchCustomClient;

        public IndexMaintainer(IElasticsearchCustomClient elasticsearchCustomClient)
        {
            _elasticsearchCustomClient = elasticsearchCustomClient;
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
