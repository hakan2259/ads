import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdsComponent } from './ads.component';
import { AdvertItemComponent } from './advert-item/advert-item.component';



@NgModule({
  declarations: [
    AdsComponent,
    AdvertItemComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [AdsComponent]
})
export class AdsModule { }
