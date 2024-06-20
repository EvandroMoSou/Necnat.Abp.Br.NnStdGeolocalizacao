using Microsoft.EntityFrameworkCore;
using Necnat.Abp.Br.NnStdGeolocalizacao.Domains;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.EntityFrameworkCore;

[ConnectionStringName(NnStdGeolocalizacaoDbProperties.ConnectionStringName)]
public interface INnStdGeolocalizacaoDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */

    //GeolocalizacaoStandart
    DbSet<Pais> Pais { get; }
}
