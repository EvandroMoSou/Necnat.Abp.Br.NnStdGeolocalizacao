using Volo.Abp.Modularity;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

[DependsOn(
    typeof(NnStdGeolocalizacaoDomainModule),
    typeof(NnStdGeolocalizacaoTestBaseModule)
)]
public class NnStdGeolocalizacaoDomainTestModule : AbpModule
{

}
