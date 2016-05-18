using Microsoft.Extensions.Options;

namespace MongoDbCache
{
    public class MongoDbCacheOptions : IOptions<MongoDbCacheOptions>
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }

        MongoDbCacheOptions IOptions<MongoDbCacheOptions>.Value => this;
    }
}