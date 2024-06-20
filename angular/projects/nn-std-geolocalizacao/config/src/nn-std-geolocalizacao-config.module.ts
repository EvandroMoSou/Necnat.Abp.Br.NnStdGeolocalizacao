import { ModuleWithProviders, NgModule } from '@angular/core';
import { NN_STD_GEOLOCALIZACAO_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class NnStdGeolocalizacaoConfigModule {
  static forRoot(): ModuleWithProviders<NnStdGeolocalizacaoConfigModule> {
    return {
      ngModule: NnStdGeolocalizacaoConfigModule,
      providers: [NN_STD_GEOLOCALIZACAO_ROUTE_PROVIDERS],
    };
  }
}
