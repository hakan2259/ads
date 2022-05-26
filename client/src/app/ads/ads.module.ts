import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdsComponent } from './ads.component';
import { AdvertItemComponent } from './advert-item/advert-item.component';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [
    AdsComponent,
    AdvertItemComponent
  ],
  imports: [
    CommonModule,
    SharedModule
  ],
  exports: [AdsComponent]
})
export class AdsModule { }
