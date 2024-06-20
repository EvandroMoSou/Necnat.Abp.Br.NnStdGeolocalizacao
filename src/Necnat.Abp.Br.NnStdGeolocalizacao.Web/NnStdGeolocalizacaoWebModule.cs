using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Necnat.Abp.Br.NnStdGeolocalizacao.Localization;
using Necnat.Abp.Br.NnStdGeolocalizacao.Web.Menus;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;
using Necnat.Abp.Br.NnStdGeolocalizacao.Permissions;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Web;

[DependsOn(
    typeof(NnStdGeolocalizacaoApplicationContractsModule),
    typeof(AbpAspNetCoreMvcUiThemeSharedModule),
    typeof(AbpAutoMapperModule)
    )]
public class NnStdGeolocalizacaoWebModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
        {
            options.AddAssemblyResource(typeof(NnStdGeolocalizacaoResource), typeof(NnStdGeolocalizacaoWebModule).Assembly);
        });

        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(NnStdGeolocalizacaoWebModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new NnStdGeolocalizacaoMenuContributor());
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<NnStdGeolocalizacaoWebModule>();
        });

        context.Services.AddAutoMapperObjectMapper<NnStdGeolocalizacaoWebModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<NnStdGeolocalizacaoWebModule>(validate: true);
        });

        Configure<RazorPagesOptions>(options =>
        {
                //Configure authorization.
            });
    }
}
