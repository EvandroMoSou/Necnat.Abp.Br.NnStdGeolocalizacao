using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

[DependsOn(
    typeof(NnStdGeolocalizacaoDomainModule),
    typeof(NnStdGeolocalizacaoApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class NnStdGeolocalizacaoApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<NnStdGeolocalizacaoApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<NnStdGeolocalizacaoApplicationModule>(validate: true);
        });
    }
}
