using System;
using System.Globalization;
using System.Threading.Tasks;

namespace ElasticsearchIndexer.ApplicationServices
{
    public class IndexerService : IIndexerService
    {
        private readonly IIndexerHelper _indexerHelper;

        public IndexerService(IIndexerHelper indexerHelper)
        {
            _indexerHelper = indexerHelper;
        }

        public async Task CreateIndex(DateTime dateTime)
        {
            var newIndexName = $"elasticIndexer-{dateTime.ToString("yyyy-MM-dd-HH-mm")}".ToLower(CultureInfo.InvariantCulture);

            _indexerHelper.CreateNewIndex(newIndexName);

            _indexerHelper.IndexEntries();
        }
    }
}
