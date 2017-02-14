using ElasticsearchIndexer.Infrastructure.Elasticsearch;
using StructureMap;

namespace ElasticsearchIndexer.Infrastructure.DependencyInjection
{
    public class InfrastructureRegistry : Registry
    {
        public InfrastructureRegistry()
        {
            For<IElasticsearchClientFactory>().Use<ElasticsearchClientFactory>();
        }
    }
}
