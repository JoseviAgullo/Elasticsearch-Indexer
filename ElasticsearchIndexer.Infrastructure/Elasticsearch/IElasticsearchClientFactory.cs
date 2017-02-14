using Nest;

namespace ElasticsearchIndexer.Infrastructure.Elasticsearch
{
    public interface IElasticsearchClientFactory
    {
        IElasticClient GetElasticClient();
    }
}