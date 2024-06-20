using Necnat.Abp.Br.NnStdGeolocalizacao.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Pages;

public abstract class NnStdGeolocalizacaoPageModel : AbpPageModel
{
    protected NnStdGeolocalizacaoPageModel()
    {
        LocalizationResourceType = typeof(NnStdGeolocalizacaoResource);
    }
}
