using System;
using Volo.Abp.Application.Dtos;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Domains
{
    public class PaisDto : EntityDto<Guid>
    {
        public string? Nome { get; set; }
        public string? NomeIngles { get; set; }
        public string? NomeFrances { get; set; }
        public string? CodigoIso3166Alpha2 { get; set; }
        public string? CodigoIso3166Alpha3 { get; set; }
        public string? CodigoIso3166Numeric { get; set; }
        public bool? InAtivo { get; set; }
    }
}
