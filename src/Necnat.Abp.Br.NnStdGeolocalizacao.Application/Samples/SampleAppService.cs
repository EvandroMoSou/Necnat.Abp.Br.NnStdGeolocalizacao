using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Samples;

public class SampleAppService : NnStdGeolocalizacaoAppService, ISampleAppService
{
    public Task<SampleDto> GetAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }

    [Authorize]
    public Task<SampleDto> GetAuthorizedAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }
}
