using Necnat.Abp.Br.NnStdGeolocalizacao.Localization;
using Volo.Abp.Application.Services;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

public abstract class NnStdGeolocalizacaoAppService : ApplicationService
{
    protected NnStdGeolocalizacaoAppService()
    {
        LocalizationResource = typeof(NnStdGeolocalizacaoResource);
        ObjectMapperContext = typeof(NnStdGeolocalizacaoApplicationModule);
    }
}
