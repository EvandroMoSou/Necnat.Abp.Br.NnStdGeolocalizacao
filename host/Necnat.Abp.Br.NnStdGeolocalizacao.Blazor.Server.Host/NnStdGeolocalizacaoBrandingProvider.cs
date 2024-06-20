using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class NnStdGeolocalizacaoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NnStdGeolocalizacao";
}
