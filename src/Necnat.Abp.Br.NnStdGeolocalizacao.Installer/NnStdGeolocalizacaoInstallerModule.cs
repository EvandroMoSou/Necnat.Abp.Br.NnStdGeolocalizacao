using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class NnStdGeolocalizacaoInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<NnStdGeolocalizacaoInstallerModule>();
        });
    }
}
