using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Samples;

[Area(NnStdGeolocalizacaoRemoteServiceConsts.ModuleName)]
[RemoteService(Name = NnStdGeolocalizacaoRemoteServiceConsts.RemoteServiceName)]
[Route("api/NnStdGeolocalizacao/sample")]
public class SampleController : NnStdGeolocalizacaoController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}
