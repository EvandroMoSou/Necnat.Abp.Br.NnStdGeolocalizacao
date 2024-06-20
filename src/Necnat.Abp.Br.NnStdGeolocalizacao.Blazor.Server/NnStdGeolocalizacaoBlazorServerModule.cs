using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(NnStdGeolocalizacaoBlazorModule)
    )]
public class NnStdGeolocalizacaoBlazorServerModule : AbpModule
{

}
