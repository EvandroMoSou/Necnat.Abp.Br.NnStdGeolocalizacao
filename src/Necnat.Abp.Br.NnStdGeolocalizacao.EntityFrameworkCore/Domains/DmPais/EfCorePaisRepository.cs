using Microsoft.EntityFrameworkCore;
using Necnat.Abp.Br.NnStdGeolocalizacao.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Domains
{
    public class EfCorePaisRepository : EfCoreRepository<NnStdGeolocalizacaoDbContext, Pais, Guid>, IPaisRepository
    {
        public EfCorePaisRepository(IDbContextProvider<NnStdGeolocalizacaoDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public async Task<Pais?> FindByCodigoIso3166NumericAsync(string codigoIso3166Numeric, bool? inAtivo = null)
        {
            var dbSet = await GetDbSetAsync();
            var q = dbSet.Where(x => x.CodigoIso3166Numeric == codigoIso3166Numeric);

            if (inAtivo != null)
                q = q.Where(x => x.InAtivo == inAtivo);

            return await q.FirstOrDefaultAsync();
        }

        public async Task<Pais?> FindByNomeAsync(string nome, bool? inAtivo = null)
        {
            var dbSet = await GetDbSetAsync();
            var q = dbSet.Where(x => x.Nome == nome);

            if (inAtivo != null)
                q = q.Where(x => x.InAtivo == inAtivo);

            return await q.FirstOrDefaultAsync();
        }

        public async Task<int> UpdateAllInAtivoAsync(bool inAtivo)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.ExecuteUpdateAsync(s => s.SetProperty(e => e.InAtivo, inAtivo));
        }
    }
}
