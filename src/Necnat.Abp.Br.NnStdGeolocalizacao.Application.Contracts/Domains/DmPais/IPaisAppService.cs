using System;
using Volo.Abp.Application.Services;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Domains
{
    public interface IPaisAppService :
        ICrudAppService<
            PaisDto,
            Guid,
            PaisResultRequestDto>
    {

    }
}
