using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NnStdGeolocalizacaoHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class NnStdGeolocalizacaoConsoleApiClientModule : AbpModule
{

}
