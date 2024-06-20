import { eLayoutType, RoutesService } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';
import { eNnStdGeolocalizacaoRouteNames } from '../enums/route-names';

export const NN_STD_GEOLOCALIZACAO_ROUTE_PROVIDERS = [
  {
    provide: APP_INITIALIZER,
    useFactory: configureRoutes,
    deps: [RoutesService],
    multi: true,
  },
];

export function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/nn-std-geolocalizacao',
        name: eNnStdGeolocalizacaoRouteNames.NnStdGeolocalizacao,
        iconClass: 'fas fa-book',
        layout: eLayoutType.application,
        order: 3,
      },
    ]);
  };
}
