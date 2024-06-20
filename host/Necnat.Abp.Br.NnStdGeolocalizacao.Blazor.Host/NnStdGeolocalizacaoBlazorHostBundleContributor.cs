using Volo.Abp.Bundling;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Blazor.Host;

public class NnStdGeolocalizacaoBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
