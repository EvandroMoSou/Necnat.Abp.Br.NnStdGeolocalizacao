import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { NnStdGeolocalizacaoComponent } from './components/nn-std-geolocalizacao.component';
import { NnStdGeolocalizacaoRoutingModule } from './nn-std-geolocalizacao-routing.module';

@NgModule({
  declarations: [NnStdGeolocalizacaoComponent],
  imports: [CoreModule, ThemeSharedModule, NnStdGeolocalizacaoRoutingModule],
  exports: [NnStdGeolocalizacaoComponent],
})
export class NnStdGeolocalizacaoModule {
  static forChild(): ModuleWithProviders<NnStdGeolocalizacaoModule> {
    return {
      ngModule: NnStdGeolocalizacaoModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<NnStdGeolocalizacaoModule> {
    return new LazyModuleFactory(NnStdGeolocalizacaoModule.forChild());
  }
}
