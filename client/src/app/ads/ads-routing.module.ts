import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { AdsComponent } from './ads.component';
import { AdvertDetailsComponent } from './advert-details/advert-details.component';

const routes : Routes = [
  { path: '', component: AdsComponent },
  { path: ':id', component: AdvertDetailsComponent },
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
  exports : [RouterModule]
})
export class AdsRoutingModule { }
