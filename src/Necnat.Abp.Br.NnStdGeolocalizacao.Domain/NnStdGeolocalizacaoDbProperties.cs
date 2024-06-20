namespace Necnat.Abp.Br.NnStdGeolocalizacao;

public static class NnStdGeolocalizacaoDbProperties
{
    public static string DbTablePrefix { get; set; } = "Glcl";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "NnStdGeolocalizacao";
}
