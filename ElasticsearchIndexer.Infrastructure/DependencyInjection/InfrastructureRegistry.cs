using ElasticsearchIndexer.Infrastructure.Elasticsearch;
using StructureMap;

namespace ElasticsearchIndexer.Infrastructure.DependencyInjection
{
    public class InfrastructureRegistry : Registry
    {
        public InfrastructureRegistry()
        {
            For<IElasticsearchCustomClient>().Use<ElasticsearchCustomClient>();
            For<IElasticsearchClientFactory>().Use<ElasticsearchClientFactory>();
        }
    }
}
