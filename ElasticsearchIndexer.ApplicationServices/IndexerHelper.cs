namespace ElasticsearchIndexer.ApplicationServices
{
    public class IndexerHelper
    {
        public bool CreateNewIndex(string newIndexName)
        {
            var indexExists = IndexExists(newIndexName);

            if (indexExists)
            {
                DeleteExistingIndex(newIndexName);
            }

            CreateNewIndex(newIndexName);

            return IndexExists(newIndexName);
        }

        private void DeleteExistingIndex(string newIndexName)
        {
            throw new System.NotImplementedException();
        }

        private bool IndexExists(string newIndexName)
        {
            throw new System.NotImplementedException();
        }

        public void IndexData()
        {
            throw new System.NotImplementedException();
        }
    }
}
