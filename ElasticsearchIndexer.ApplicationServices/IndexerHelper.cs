using ElasticsearchIndexer.Infrastructure.Elasticsearch;
using ElasticsearchIndexer.Infrastructure.Repository;

namespace ElasticsearchIndexer.ApplicationServices
{
    public class IndexerHelper : IIndexerHelper
    {
        private readonly IIndexMaintainer _elasticIndexMaintainer;
        private readonly IProductRepository _productRepository;

        public IndexerHelper(IIndexMaintainer elasticIndexMaintainer, IProductRepository productRepository)
        {
            _elasticIndexMaintainer = elasticIndexMaintainer;
            _productRepository = productRepository;
        }

        public bool CreateNewIndex(string newIndexName)
        {
            var indexExists = _elasticIndexMaintainer.IndexExists(newIndexName);

            if (indexExists)
            {
                _elasticIndexMaintainer.DeleteIndex(newIndexName);
            }

            _elasticIndexMaintainer.CreateIndex(newIndexName);

            return _elasticIndexMaintainer.IndexExists(newIndexName);
        }

        public bool IsIndexCorrectlyCreated(string indexName)
        {
            return _elasticIndexMaintainer.IndexContainsDocuments(indexName);
        }

        public void IndexEntries()
        {
            var products = _productRepository.GetAllProducts();
        }
    }
}
