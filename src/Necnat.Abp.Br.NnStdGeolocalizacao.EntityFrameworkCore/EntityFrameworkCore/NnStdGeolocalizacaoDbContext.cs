using Microsoft.EntityFrameworkCore;
using Necnat.Abp.Br.NnStdGeolocalizacao.Domains;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.EntityFrameworkCore;

[ConnectionStringName(NnStdGeolocalizacaoDbProperties.ConnectionStringName)]
public class NnStdGeolocalizacaoDbContext : AbpDbContext<NnStdGeolocalizacaoDbContext>, INnStdGeolocalizacaoDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
    public DbSet<Pais> Pais { get; set; }

    public NnStdGeolocalizacaoDbContext(DbContextOptions<NnStdGeolocalizacaoDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureNnStdGeolocalizacao();
    }
}
