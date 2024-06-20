import { TestBed } from '@angular/core/testing';
import { NnStdGeolocalizacaoService } from './services/nn-std-geolocalizacao.service';
import { RestService } from '@abp/ng.core';

describe('NnStdGeolocalizacaoService', () => {
  let service: NnStdGeolocalizacaoService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(NnStdGeolocalizacaoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
