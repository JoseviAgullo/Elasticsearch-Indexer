using ElasticsearchIndexer.Infrastructure.DependencyInjection;
using StructureMap;

namespace IndexerWorkerRole.DependencyInjection
{
    public class IoC
    {
        public static IContainer Initialize()
        {
            return new Container(c =>
            {
                c.AddRegistry<InfrastructureRegistry>();
            });
        }
    }
}
