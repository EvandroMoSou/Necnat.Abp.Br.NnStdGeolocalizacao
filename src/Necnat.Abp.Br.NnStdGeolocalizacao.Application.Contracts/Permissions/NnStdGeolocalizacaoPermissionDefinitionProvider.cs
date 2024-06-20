using Necnat.Abp.Br.NnStdGeolocalizacao.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Permissions;

public class NnStdGeolocalizacaoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NnStdGeolocalizacaoPermissions.GroupName, L("Permission:NnStdGeolocalizacao"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NnStdGeolocalizacaoResource>(name);
    }
}
