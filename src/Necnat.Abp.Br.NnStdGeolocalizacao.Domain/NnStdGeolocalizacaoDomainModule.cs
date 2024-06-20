using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(NnStdGeolocalizacaoDomainSharedModule)
)]
public class NnStdGeolocalizacaoDomainModule : AbpModule
{

}
