using Necnat.Abp.Br.NnStdGeolocalizacao.Samples;
using Xunit;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.MongoDB.Samples;

[Collection(MongoTestCollection.Name)]
public class SampleRepository_Tests : SampleRepository_Tests<NnStdGeolocalizacaoMongoDbTestModule>
{
    /* Don't write custom repository tests here, instead write to
     * the base class.
     * One exception can be some specific tests related to MongoDB.
     */
}
