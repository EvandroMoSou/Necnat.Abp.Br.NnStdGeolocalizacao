using Volo.Abp.Modularity;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class NnStdGeolocalizacaoApplicationTestBase<TStartupModule> : NnStdGeolocalizacaoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
