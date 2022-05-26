import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IAdvert } from 'src/app/shared/models/advert';
import { AdsService } from '../ads.service';

@Component({
  selector: 'app-advert-details',
  templateUrl: './advert-details.component.html',
  styleUrls: ['./advert-details.component.scss'],
})
export class AdvertDetailsComponent implements OnInit {
  advert: IAdvert;

  constructor(private adsService: AdsService, private activatedRoute: ActivatedRoute) {}

  ngOnInit(): void {
    this.loadAdvert();
  }

  loadAdvert() {
    this.adsService.getAdvert(+this.activatedRoute.snapshot.paramMap.get('id')).subscribe(
      (advert) => {
        this.advert = advert;
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
