using Volo.Abp.Reflection;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Permissions;

public class NnStdGeolocalizacaoPermissions
{
    public const string GroupName = "NnStdGeolocalizacao";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(NnStdGeolocalizacaoPermissions));
    }
}
