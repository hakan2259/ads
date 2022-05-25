import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IPagination } from '../shared/models/pagination';

@Injectable({
  providedIn: 'root'
})
export class AdsService {
  baseUrl = "http://localhost:5000/api/"

  constructor(private http: HttpClient) { }

  getAdverts(){
    return this.http.get<IPagination>(this.baseUrl + 'adverts?pageSize=50');

  }
}
