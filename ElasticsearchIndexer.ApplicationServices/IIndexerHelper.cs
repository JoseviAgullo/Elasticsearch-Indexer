using System.Threading.Tasks;

namespace ElasticsearchIndexer.ApplicationServices
{
    public interface IIndexerHelper
    {
        bool CreateNewIndex(string newIndexName);
        bool IsIndexCorrectlyCreated(string indexName);
        Task IndexEntries(string indexName);
    }
}