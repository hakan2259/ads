import { Component, Input, OnInit } from '@angular/core';
import { IAdvert } from 'src/app/shared/models/advert';

@Component({
  selector: 'app-advert-item',
  templateUrl: './advert-item.component.html',
  styleUrls: ['./advert-item.component.scss']
})
export class AdvertItemComponent implements OnInit {
  @Input() advert : IAdvert;

  constructor() { }

  ngOnInit(): void {
  }

}
