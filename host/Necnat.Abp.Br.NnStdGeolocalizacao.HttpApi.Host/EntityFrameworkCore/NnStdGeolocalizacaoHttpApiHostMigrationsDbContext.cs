using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.EntityFrameworkCore;

public class NnStdGeolocalizacaoHttpApiHostMigrationsDbContext : AbpDbContext<NnStdGeolocalizacaoHttpApiHostMigrationsDbContext>
{
    public NnStdGeolocalizacaoHttpApiHostMigrationsDbContext(DbContextOptions<NnStdGeolocalizacaoHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureNnStdGeolocalizacao();
    }
}
