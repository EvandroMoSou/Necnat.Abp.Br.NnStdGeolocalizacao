using Necnat.Abp.Br.NnStdGeolocalizacao.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

public abstract class NnStdGeolocalizacaoController : AbpControllerBase
{
    protected NnStdGeolocalizacaoController()
    {
        LocalizationResource = typeof(NnStdGeolocalizacaoResource);
    }
}
