import { IAdvert } from "./advert";

export interface IPagination {
  pageIndex: number;
  pageSize: number;
  count: number;
  data: IAdvert[];
}
