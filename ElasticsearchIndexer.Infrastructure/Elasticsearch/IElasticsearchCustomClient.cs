using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nest;

namespace ElasticsearchIndexer.Infrastructure.Elasticsearch
{
    public interface IElasticsearchCustomClient
    {
        IBulkAliasResponse Alias(IBulkAliasRequest request);
        IBulkAliasResponse Alias(Func<BulkAliasDescriptor, IBulkAliasRequest> selector);
        IExistsResponse AliasExists(Func<AliasExistsDescriptor, IAliasExistsRequest> selector);
        Task<IBulkResponse> BulkAsync(IBulkRequest request);
        ICreateIndexResponse CreateIndex(IndexName index, Func<CreateIndexDescriptor, ICreateIndexRequest> selector = null);
        IDeleteIndexResponse DeleteIndex(IndexName index);
        IList<string> GetIndicesPointingToAlias(string aliasName);
        IGetMappingResponse GetMapping<T>(Func<GetMappingDescriptor<T>, IGetMappingRequest> selector = null) where T : class;
        IExistsResponse IndexExists(IndexName index);
        IIndicesStatsResponse IndicesStats(Indices indices, Func<IndicesStatsDescriptor, IIndicesStatsRequest> selector = null);
        IRefreshResponse Refresh(IRefreshRequest request);
        IRefreshResponse Refresh(Indices indices, Func<RefreshDescriptor, IRefreshRequest> selector = null);
        ISearchResponse<T> Search<T>(Func<SearchDescriptor<T>, ISearchRequest> selector) where T : class;
    }
}