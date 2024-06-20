using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.MongoDB;

[DependsOn(
    typeof(NnStdGeolocalizacaoApplicationTestModule),
    typeof(NnStdGeolocalizacaoMongoDbModule)
)]
public class NnStdGeolocalizacaoMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
        });
    }
}
