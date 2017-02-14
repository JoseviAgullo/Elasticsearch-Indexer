using System;
using Elasticsearch.Net;
using ElasticsearchIndexer.Infrastructure.Settings;
using Nest;

namespace ElasticsearchIndexer.Infrastructure.Elasticsearch
{
    public class ElasticsearchClientFactory : IElasticsearchClientFactory
    {
        private readonly IInfrastructureSettings _infrastructureSettings;

        public ElasticsearchClientFactory(IInfrastructureSettings infrastructureSettings)
        {
            _infrastructureSettings = infrastructureSettings;
        }

        public IElasticClient GetElasticClient()
        {
            using (var settings = new ConnectionSettings(new Uri(_infrastructureSettings.ElasticServerUrls)))
            {
                return new ElasticClient(settings);
            }
        }
    }
}