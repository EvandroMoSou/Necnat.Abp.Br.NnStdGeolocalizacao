using Necnat.Abp.Br.NnStdGeolocalizacao.MongoDB;
using Necnat.Abp.Br.NnStdGeolocalizacao.Samples;
using Xunit;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<NnStdGeolocalizacaoMongoDbTestModule>
{

}
