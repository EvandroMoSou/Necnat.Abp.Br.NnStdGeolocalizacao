﻿using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Necnat.Abp.Br.NnStdGeolocalizacao.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
