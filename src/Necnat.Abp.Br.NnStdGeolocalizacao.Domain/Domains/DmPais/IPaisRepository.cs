using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Domains
{
    public interface IPaisRepository : IRepository<Pais, Guid>
    {
        Task<Pais?> FindByCodigoIso3166NumericAsync(string codigoIso3166Numeric, bool? inAtivo = null);
        Task<Pais?> FindByNomeAsync(string nome, bool? inAtivo = null);
        Task<int> UpdateAllInAtivoAsync(bool inAtivo);
    }
}
