namespace ElasticsearchIndexer.ApplicationServices
{
    public interface IIndexerHelper
    {
        bool CreateNewIndex(string newIndexName);
        bool IsIndexCorrectlyCreated(string indexName);
        void IndexEntries();
    }
}