import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdsComponent } from './ads.component';
import { AdvertItemComponent } from './advert-item/advert-item.component';
import { SharedModule } from '../shared/shared.module';
import { AdvertDetailsComponent } from './advert-details/advert-details.component';
import { AdsRoutingModule } from './ads-routing.module';



@NgModule({
  declarations: [
    AdsComponent,
    AdvertItemComponent,
    AdvertDetailsComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    AdsRoutingModule
  ]
})
export class AdsModule { }
