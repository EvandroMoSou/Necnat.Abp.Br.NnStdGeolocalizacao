using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

[DependsOn(
    typeof(NnStdGeolocalizacaoApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class NnStdGeolocalizacaoHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(NnStdGeolocalizacaoApplicationContractsModule).Assembly,
            NnStdGeolocalizacaoRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<NnStdGeolocalizacaoHttpApiClientModule>();
        });

    }
}
