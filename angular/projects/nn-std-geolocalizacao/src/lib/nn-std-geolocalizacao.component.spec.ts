import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { NnStdGeolocalizacaoComponent } from './components/nn-std-geolocalizacao.component';
import { NnStdGeolocalizacaoService } from '@necnat.Abp.Br/nn-std-geolocalizacao';
import { of } from 'rxjs';

describe('NnStdGeolocalizacaoComponent', () => {
  let component: NnStdGeolocalizacaoComponent;
  let fixture: ComponentFixture<NnStdGeolocalizacaoComponent>;
  const mockNnStdGeolocalizacaoService = jasmine.createSpyObj('NnStdGeolocalizacaoService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [NnStdGeolocalizacaoComponent],
      providers: [
        {
          provide: NnStdGeolocalizacaoService,
          useValue: mockNnStdGeolocalizacaoService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NnStdGeolocalizacaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
