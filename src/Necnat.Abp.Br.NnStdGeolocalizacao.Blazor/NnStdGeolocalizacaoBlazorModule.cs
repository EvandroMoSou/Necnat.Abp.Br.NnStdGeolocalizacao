using Microsoft.Extensions.DependencyInjection;
using Necnat.Abp.Br.NnStdGeolocalizacao.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Blazor;

[DependsOn(
    typeof(NnStdGeolocalizacaoApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class NnStdGeolocalizacaoBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<NnStdGeolocalizacaoBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<NnStdGeolocalizacaoBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new NnStdGeolocalizacaoMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(NnStdGeolocalizacaoBlazorModule).Assembly);
        });
    }
}
