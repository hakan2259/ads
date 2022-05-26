import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ICategory } from '../shared/models/category';
import { IPagination } from '../shared/models/pagination';
import { delay, map } from 'rxjs/operators';
import { AdsParams } from '../shared/models/adsParams';
import { IAdvert } from '../shared/models/advert';

@Injectable({
  providedIn: 'root',
})
export class AdsService {
  baseUrl = 'http://localhost:5000/api/';

  constructor(private http: HttpClient) {}

  getAdverts(adsParams: AdsParams) {
    let params = new HttpParams();
    if (adsParams.categoryId !== 0) {
      params = params.append('categoryId', adsParams.categoryId.toString());
    }
   if(adsParams.search){
     params = params.append('search',adsParams.search);
   }

    params = params.append('sort', adsParams.sort);
    params = params.append('pageIndex', adsParams.pageNumber.toString());
    params = params.append('pageIndex', adsParams.pageSize.toString());

    return this.http
      .get<IPagination>(this.baseUrl + 'adverts', {
        observe: 'response',
        params,
      })
      .pipe(
        map((response) => {
          return response.body;
        })
      );
  }
  getAdvert(id:number){
    return this.http.get<IAdvert>(this.baseUrl + "adverts/" +id);
  }
  getCategories() {
    return this.http.get<ICategory[]>(this.baseUrl + 'categories');
  }
}
