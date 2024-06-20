using Necnat.Abp.NnLibCommon.Dtos;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Domains
{
    public class PaisResultRequestDto : OptionalPagedAndSortedResultRequestDto
    {
        public string? NomeContains { get; set; }
        public string? CodigoIso3166Alpha2 { get; set; }
        public string? CodigoIso3166Alpha3 { get; set; }
        public string? CodigoIso3166Numeric { get; set; }
        public bool? InAtivo { get; set; }
    }
}
