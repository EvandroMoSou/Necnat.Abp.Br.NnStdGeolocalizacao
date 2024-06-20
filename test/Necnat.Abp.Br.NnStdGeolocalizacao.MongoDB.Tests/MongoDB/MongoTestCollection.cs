using Xunit;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.MongoDB;

[CollectionDefinition(Name)]
public class MongoTestCollection : ICollectionFixture<MongoDbFixture>
{
    public const string Name = "MongoDB Collection";
}
