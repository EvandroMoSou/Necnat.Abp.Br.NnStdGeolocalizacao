using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Blazor.WebAssembly;

[DependsOn(
    typeof(NnStdGeolocalizacaoBlazorModule),
    typeof(NnStdGeolocalizacaoHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class NnStdGeolocalizacaoBlazorWebAssemblyModule : AbpModule
{

}
