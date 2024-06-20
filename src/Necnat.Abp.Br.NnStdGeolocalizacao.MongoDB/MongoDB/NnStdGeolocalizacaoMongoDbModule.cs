using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.MongoDB;

[DependsOn(
    typeof(NnStdGeolocalizacaoDomainModule),
    typeof(AbpMongoDbModule)
    )]
public class NnStdGeolocalizacaoMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<NnStdGeolocalizacaoMongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
