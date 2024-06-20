using Necnat.Abp.Br.NnStdGeolocalizacao.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Blazor.Server.Host;

public abstract class NnStdGeolocalizacaoComponentBase : AbpComponentBase
{
    protected NnStdGeolocalizacaoComponentBase()
    {
        LocalizationResource = typeof(NnStdGeolocalizacaoResource);
    }
}
