using System;
using System.Globalization;
using System.Threading.Tasks;

namespace ElasticsearchIndexer.ApplicationServices
{
    public class IndexerService
    {
        public IndexerService()
        {
            
        }

        public async Task CreateIndex(DateTime dateTime)
        {
            var newIndexName = $"elasticIndexer-{dateTime.ToString("yyyy-MM-dd-HH-mm")}".ToLower(CultureInfo.InvariantCulture);

            var indexerHelper = new IndexerHelper();

            indexerHelper.CreateNewIndex(newIndexName);
        }
    }
}
