using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Pages;

public class IndexModel : NnStdGeolocalizacaoPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
