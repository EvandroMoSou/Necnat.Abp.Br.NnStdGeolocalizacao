using Volo.Abp.Modularity;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class NnStdGeolocalizacaoDomainTestBase<TStartupModule> : NnStdGeolocalizacaoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
