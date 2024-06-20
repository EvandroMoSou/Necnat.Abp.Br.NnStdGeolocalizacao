using Volo.Abp.Reflection;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Permissions;

public class NnStdGeolocalizacaoPermissions
{
    public const string GroupName = "NnStdGeolocalizacao";

    public static class PrmPais
    {
        public const string Default = GroupName + ".Pais";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(NnStdGeolocalizacaoPermissions));
    }
}
