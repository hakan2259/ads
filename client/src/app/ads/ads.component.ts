import { Component, OnInit } from '@angular/core';
import { IAdvert } from '../shared/models/advert';
import { AdsService } from './ads.service';

@Component({
  selector: 'app-ads',
  templateUrl: './ads.component.html',
  styleUrls: ['./ads.component.scss'],
})
export class AdsComponent implements OnInit {
  adverts: IAdvert[];
  constructor(private adsService: AdsService) {}

  ngOnInit(): void {
    this.adsService.getAdverts().subscribe(
      (response) => {
        this.adverts = response.data;
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
