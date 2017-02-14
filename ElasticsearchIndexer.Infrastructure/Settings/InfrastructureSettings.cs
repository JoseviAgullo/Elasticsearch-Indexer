using System.Net;

namespace ElasticsearchIndexer.Infrastructure.Settings
{
    public class InfrastructureSettings : IInfrastructureSettings
    {
        public string ElasticServerUrls => "http://192.168.99.100:9200";
    }
}
