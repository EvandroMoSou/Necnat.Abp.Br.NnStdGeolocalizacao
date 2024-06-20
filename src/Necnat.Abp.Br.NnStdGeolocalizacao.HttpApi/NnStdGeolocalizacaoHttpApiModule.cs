using Localization.Resources.AbpUi;
using Necnat.Abp.Br.NnStdGeolocalizacao.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

[DependsOn(
    typeof(NnStdGeolocalizacaoApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class NnStdGeolocalizacaoHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(NnStdGeolocalizacaoHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<NnStdGeolocalizacaoResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
