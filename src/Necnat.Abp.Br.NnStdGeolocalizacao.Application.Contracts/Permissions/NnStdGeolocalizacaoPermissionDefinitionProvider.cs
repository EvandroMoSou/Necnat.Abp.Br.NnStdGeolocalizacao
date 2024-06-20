using Necnat.Abp.Br.NnStdGeolocalizacao.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Permissions;

public class NnStdGeolocalizacaoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NnStdGeolocalizacaoPermissions.GroupName, L("Permission:NnStdGeolocalizacao"));

        var pgPais = myGroup.AddPermission(NnStdGeolocalizacaoPermissions.PrmPais.Default, L("Permission:Pais:Default"));
        pgPais.AddChild(NnStdGeolocalizacaoPermissions.PrmPais.Create, L("Permission:Pais:Create"));
        pgPais.AddChild(NnStdGeolocalizacaoPermissions.PrmPais.Update, L("Permission:Pais:Update"));
        pgPais.AddChild(NnStdGeolocalizacaoPermissions.PrmPais.Delete, L("Permission:Pais:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NnStdGeolocalizacaoResource>(name);
    }
}
