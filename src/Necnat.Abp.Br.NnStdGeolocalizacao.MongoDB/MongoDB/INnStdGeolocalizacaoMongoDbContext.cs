using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.MongoDB;

[ConnectionStringName(NnStdGeolocalizacaoDbProperties.ConnectionStringName)]
public interface INnStdGeolocalizacaoMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
