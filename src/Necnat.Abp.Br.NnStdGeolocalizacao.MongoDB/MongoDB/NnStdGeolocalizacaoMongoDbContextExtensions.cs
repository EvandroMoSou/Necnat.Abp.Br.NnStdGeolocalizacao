using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.MongoDB;

public static class NnStdGeolocalizacaoMongoDbContextExtensions
{
    public static void ConfigureNnStdGeolocalizacao(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
