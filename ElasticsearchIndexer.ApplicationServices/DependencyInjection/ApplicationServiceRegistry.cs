using StructureMap;

namespace ElasticsearchIndexer.ApplicationServices.DependencyInjection
{
    public class ApplicationServiceRegistry : Registry
    {
        public ApplicationServiceRegistry()
        {
            For<IIndexerHelper>().Use<IndexerHelper>();
            For<IIndexerService>().Use<IndexerService>();
        }
    }
}
