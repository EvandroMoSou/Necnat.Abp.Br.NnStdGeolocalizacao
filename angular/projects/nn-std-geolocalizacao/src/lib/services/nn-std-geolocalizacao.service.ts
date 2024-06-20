import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class NnStdGeolocalizacaoService {
  apiName = 'NnStdGeolocalizacao';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/NnStdGeolocalizacao/sample' },
      { apiName: this.apiName }
    );
  }
}
