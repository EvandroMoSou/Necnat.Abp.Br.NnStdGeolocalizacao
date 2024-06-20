﻿using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Necnat.Abp.Br.NnStdGeolocalizacao;

[DependsOn(
    typeof(NnStdGeolocalizacaoDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class NnStdGeolocalizacaoApplicationContractsModule : AbpModule
{

}
