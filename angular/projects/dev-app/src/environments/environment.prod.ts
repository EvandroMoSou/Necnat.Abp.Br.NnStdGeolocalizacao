import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'NnStdGeolocalizacao',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44379/',
    redirectUri: baseUrl,
    clientId: 'NnStdGeolocalizacao_App',
    responseType: 'code',
    scope: 'offline_access NnStdGeolocalizacao',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44379',
      rootNamespace: 'Necnat.Abp.Br.NnStdGeolocalizacao',
    },
    NnStdGeolocalizacao: {
      url: 'https://localhost:44317',
      rootNamespace: 'Necnat.Abp.Br.NnStdGeolocalizacao',
    },
  },
} as Environment;
