using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.EntityFrameworkCore;

public class NnStdGeolocalizacaoHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<NnStdGeolocalizacaoHttpApiHostMigrationsDbContext>
{
    public NnStdGeolocalizacaoHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<NnStdGeolocalizacaoHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("NnStdGeolocalizacao"));

        return new NnStdGeolocalizacaoHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
