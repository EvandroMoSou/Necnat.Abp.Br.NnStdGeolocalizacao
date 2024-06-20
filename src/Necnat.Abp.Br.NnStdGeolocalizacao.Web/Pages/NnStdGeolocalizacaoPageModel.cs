using Necnat.Abp.Br.NnStdGeolocalizacao.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class NnStdGeolocalizacaoPageModel : AbpPageModel
{
    protected NnStdGeolocalizacaoPageModel()
    {
        LocalizationResourceType = typeof(NnStdGeolocalizacaoResource);
        ObjectMapperContext = typeof(NnStdGeolocalizacaoWebModule);
    }
}
