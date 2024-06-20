import { Component, OnInit } from '@angular/core';
import { NnStdGeolocalizacaoService } from '../services/nn-std-geolocalizacao.service';

@Component({
  selector: 'lib-nn-std-geolocalizacao',
  template: ` <p>nn-std-geolocalizacao works!</p> `,
  styles: [],
})
export class NnStdGeolocalizacaoComponent implements OnInit {
  constructor(private service: NnStdGeolocalizacaoService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
