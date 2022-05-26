import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { AdsParams } from '../shared/models/adsParams';
import { IAdvert } from '../shared/models/advert';
import { ICategory } from '../shared/models/category';
import { AdsService } from './ads.service';

@Component({
  selector: 'app-ads',
  templateUrl: './ads.component.html',
  styleUrls: ['./ads.component.scss'],
})
export class AdsComponent implements OnInit {
  @ViewChild('search', { static: true }) searchTerm: ElementRef;
  adverts: IAdvert[];
  categories: ICategory[];
  adsParams = new AdsParams();
  totalCount: number;
  sortOptions = [
    { name: 'Alphabetical', value: 'title' },
    { name: 'Price: Low to High', value: 'priceAsc' },
    { name: 'Price High to Low', value: 'priceDesc' },
  ];
  constructor(private adsService: AdsService) {}

  ngOnInit(): void {
    this.getAdverts();
    this.getCategories();
  }
  getAdverts() {
    this.adsService.getAdverts(this.adsParams).subscribe(
      (response) => {
        this.adverts = response.data;
        this.adsParams.pageNumber = response.pageIndex;
        this.adsParams.pageSize = response.pageSize;
        this.totalCount = response.count;
      },
      (error) => {
        console.log(error);
      }
    );
  }

  getCategories() {
    this.adsService.getCategories().subscribe(
      (response) => {
        this.categories = [
          { id: 0, name: 'All', description: 'no description' },
          ...response,
        ];
      },
      (error) => {
        console.log(error);
      }
    );
  }
  onCategorySelected(categoryId: number) {
    this.adsParams.categoryId = categoryId;
    this.adsParams.pageNumber = 1;
    this.getAdverts();
  }
  onSortSelected(sort: string) {
    this.adsParams.sort = sort;
    this.getAdverts();
  }

  onPageChanged(event: any) {
    if (this.adsParams.pageNumber !== event) {
      this.adsParams.pageNumber = event.page;
      this.getAdverts();
    }
  }
  onSearch() {
    this.adsParams.search = this.searchTerm.nativeElement.value;
    this.adsParams.pageNumber = 1;
    this.getAdverts();
  }
  onReset() {
    this.searchTerm.nativeElement.value = '';
    this.adsParams = new AdsParams();
    this.getAdverts();
  }
}
