using ElasticsearchIndexer.Infrastructure.Elasticsearch;
using ElasticsearchIndexer.Infrastructure.Repository;
using StructureMap;

namespace ElasticsearchIndexer.Infrastructure.DependencyInjection
{
    public class InfrastructureRegistry : Registry
    {
        public InfrastructureRegistry()
        {
            For<IElasticsearchClientFactory>().Use<ElasticsearchClientFactory>();
            For<IProductRepository>().Use<ProductRepository>();
        }
    }
}
