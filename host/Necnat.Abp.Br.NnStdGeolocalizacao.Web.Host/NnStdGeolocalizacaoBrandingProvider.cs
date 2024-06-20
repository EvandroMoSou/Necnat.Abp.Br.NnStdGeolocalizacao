using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

[Dependency(ReplaceServices = true)]
public class NnStdGeolocalizacaoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NnStdGeolocalizacao";
}
