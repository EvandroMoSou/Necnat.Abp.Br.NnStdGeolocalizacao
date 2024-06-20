using Microsoft.Extensions.DependencyInjection;
using Necnat.Abp.Br.NnStdGeolocalizacao.Domains;
using Necnat.Abp.NnLibCommon.Extensions;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.ObjectMapping;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.DataSeeders
{
    public class Iso3166DataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IPaisRepository _paisRepository;

        public Iso3166DataSeederContributor(IPaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _paisRepository.GetCountAsync() <= 0)
            {
                var resourceName = "Necnat.Abp.Br.NnStdGeolocalizacao.DataSeeders.Iso3166.ISO3166_20230921.json";
                var lIso3166 = await Assembly.GetAssembly(typeof(Iso3166DataSeederContributor))!.GetManifestResourceListOfAsync<Pais>(resourceName);

                if (lIso3166 == null)
                    throw new FileLoadException($"[{resourceName}] Arquivo inválido.");

                await _paisRepository.UpdateAllInAtivoAsync(false);

                foreach (var iIso3166 in lIso3166)
                {
                    var isInsert = false;
                    var eDb = await _paisRepository.FindByCodigoIso3166NumericAsync(iIso3166.CodigoIso3166Numeric!);
                    if (eDb == null)
                    {
                        eDb = new Pais();
                        isInsert = true;
                    }

                    eDb = ObjectMapper.Map(iIso3166, eDb);

                    if (isInsert)
                        eDb = await _paisRepository.InsertAsync(eDb);
                    else
                        eDb = await _paisRepository.UpdateAsync(eDb);
                }
            }
        }

        #region LazyServiceProvider

        public IAbpLazyServiceProvider LazyServiceProvider { get; set; } = default!;

        protected Type? ObjectMapperContext { get; set; }
        protected IObjectMapper ObjectMapper => LazyServiceProvider.LazyGetService<IObjectMapper>(provider =>
            ObjectMapperContext == null
                ? provider.GetRequiredService<IObjectMapper>()
                : (IObjectMapper)provider.GetRequiredService(typeof(IObjectMapper<>).MakeGenericType(ObjectMapperContext)));

        #endregion
    }
}
