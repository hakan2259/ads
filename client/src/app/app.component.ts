import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IAdvert } from './models/advert';
import { IPagination } from './models/pagination';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  title = 'Ads';
  adverts:IAdvert[];

  constructor(private http: HttpClient) {}
  ngOnInit(): void {
    this.http.get('http://localhost:5000/api/adverts').subscribe(
      (response: IPagination) => {
        this.adverts = response.data;
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
