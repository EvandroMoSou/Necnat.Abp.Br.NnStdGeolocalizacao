using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.MongoDB;

[ConnectionStringName(NnStdGeolocalizacaoDbProperties.ConnectionStringName)]
public class NnStdGeolocalizacaoMongoDbContext : AbpMongoDbContext, INnStdGeolocalizacaoMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureNnStdGeolocalizacao();
    }
}
