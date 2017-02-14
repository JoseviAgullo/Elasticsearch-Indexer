using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nest;

namespace ElasticsearchIndexer.Infrastructure.Elasticsearch
{
    public class ElasticsearchCustomClient : IElasticsearchCustomClient
    {
        private readonly IElasticClient _client;

        public ElasticsearchCustomClient(IElasticsearchClientFactory elasticsearchClientFactory)
        {
            _client = elasticsearchClientFactory.GetElasticClient();
        }

        public ISearchResponse<T> Search<T>(Func<SearchDescriptor<T>, ISearchRequest> selector)
            where T : class
        {
            var result = _client.Search(selector);

            return result;
        }

        public IExistsResponse IndexExists(IndexName index)
        {
            var result = _client.IndexExists(index);
            return result;
        }

        public IDeleteIndexResponse DeleteIndex(IndexName index)
        {
            var result = _client.DeleteIndex(index);
            return result;
        }

        public IGetMappingResponse GetMapping<T>(Func<GetMappingDescriptor<T>, IGetMappingRequest> selector = null)
            where T : class
        {
            var result = _client.GetMapping(selector);
            return result;
        }

        public IRefreshResponse Refresh(IRefreshRequest request)
        {
            var result = _client.Refresh(request);
            return result;
        }

        public IRefreshResponse Refresh(Indices indices, Func<RefreshDescriptor, IRefreshRequest> selector = null)
        {
            var result = _client.Refresh(indices);
            return result;
        }

        public IExistsResponse AliasExists(Func<AliasExistsDescriptor, IAliasExistsRequest> selector)
        {
            var result = _client.AliasExists(selector);
            return result;
        }

        public IBulkAliasResponse Alias(Func<BulkAliasDescriptor, IBulkAliasRequest> selector)
        {
            var result = _client.Alias(selector);
            return result;
        }

        public IBulkAliasResponse Alias(IBulkAliasRequest request)
        {
            var result = _client.Alias(request);
            return result;
        }

        public IIndicesStatsResponse IndicesStats(Indices indices, Func<IndicesStatsDescriptor, IIndicesStatsRequest> selector = null)
        {
            var result = _client.IndicesStats(indices, selector);
            return result;
        }

        public IList<string> GetIndicesPointingToAlias(string aliasName)
        {
            var result = _client.GetIndicesPointingToAlias(aliasName);
            return result.ToList();
        }

        public ICreateIndexResponse CreateIndex(IndexName index, Func<CreateIndexDescriptor, ICreateIndexRequest> selector = null)
        {
            var result = _client.CreateIndex(index, selector);
            return result;
        }

        public virtual Task<IBulkResponse> BulkAsync(IBulkRequest request)
        {
            var result = _client.BulkAsync(request);
            return result;
        }
    }
}