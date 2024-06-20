using Microsoft.Extensions.Localization;
using Necnat.Abp.Br.NnStdGeolocalizacao.Permissions;
using Necnat.Abp.NnLibCommon.Localization;
using Necnat.Abp.NnLibCommon.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Domains
{
    public class PaisAppService : NecnatAppService<Pais, PaisDto, Guid, PaisResultRequestDto, IPaisRepository>, IPaisAppService
    {
        public PaisAppService(IStringLocalizer<NnLibCommonResource> necnatLocalizer,
            IPaisRepository repository) : base(necnatLocalizer, repository)
        {
            GetPolicyName = NnStdGeolocalizacaoPermissions.PrmPais.Default;
            GetListPolicyName = NnStdGeolocalizacaoPermissions.PrmPais.Default;
            CreatePolicyName = NnStdGeolocalizacaoPermissions.PrmPais.Create;
            UpdatePolicyName = NnStdGeolocalizacaoPermissions.PrmPais.Update;
            DeletePolicyName = NnStdGeolocalizacaoPermissions.PrmPais.Delete;
        }

        protected override async Task<IQueryable<Pais>> CreateFilteredQueryAsync(PaisResultRequestDto input)
        {
            ThrowIfIsNotNull(PaisValidator.Validate(input, _necnatLocalizer));

            var q = await ReadOnlyRepository.GetQueryableAsync();

            if (!string.IsNullOrWhiteSpace(input.NomeContains))
                q = q.Where(x => x.Nome.Contains(input.NomeContains));

            if (!string.IsNullOrWhiteSpace(input.CodigoIso3166Alpha2))
                q = q.Where(x => x.CodigoIso3166Alpha2 != null && x.CodigoIso3166Alpha2 == input.CodigoIso3166Alpha2);

            if (!string.IsNullOrWhiteSpace(input.CodigoIso3166Alpha3))
                q = q.Where(x => x.CodigoIso3166Alpha3 != null && x.CodigoIso3166Alpha3 == input.CodigoIso3166Alpha3);

            if (!string.IsNullOrWhiteSpace(input.CodigoIso3166Numeric))
                q = q.Where(x => x.CodigoIso3166Numeric != null && x.CodigoIso3166Numeric == input.CodigoIso3166Numeric);

            if (input.InAtivo != null)
                q = q.Where(x => x.InAtivo == input.InAtivo);

            return q;
        }

        protected override Task<PaisDto> CheckCreateInputAsync(PaisDto input)
        {
            ThrowIfIsNotNull(PaisValidator.Validate(input, _necnatLocalizer));
            return Task.FromResult(input);
        }

        protected override Task<PaisDto> CheckUpdateInputAsync(PaisDto input)
        {
            ThrowIfIsNotNull(PaisValidator.Validate(input, _necnatLocalizer));
            return Task.FromResult(input);
        }
    }
}
