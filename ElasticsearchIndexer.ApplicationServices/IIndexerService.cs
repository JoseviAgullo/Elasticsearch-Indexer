using System;
using System.Threading.Tasks;

namespace ElasticsearchIndexer.ApplicationServices
{
    public interface IIndexerService
    {
        Task CreateIndex(DateTime dateTime);
    }
}