using Necnat.Abp.Br.NnStdGeolocalizacao.Samples;
using Xunit;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<NnStdGeolocalizacaoMongoDbTestModule>
{

}
