namespace ElasticsearchIndexer.Infrastructure.Elasticsearch
{
    public interface IIndexMaintainer
    {
        bool DeleteIndex(string indexName);
        bool IndexExists(string indexName);
        void CreateIndex(string newIndexName);
        bool IndexContainsDocuments(string indexName);
    }
}