using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Blazor.Menus;

public class NnStdGeolocalizacaoMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(NnStdGeolocalizacaoMenus.Prefix, displayName: "NnStdGeolocalizacao", "/NnStdGeolocalizacao", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
