using Volo.Abp.Modularity;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

[DependsOn(
    typeof(NnStdGeolocalizacaoApplicationModule),
    typeof(NnStdGeolocalizacaoDomainTestModule)
    )]
public class NnStdGeolocalizacaoApplicationTestModule : AbpModule
{

}
