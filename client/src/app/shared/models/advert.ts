export interface IAdvert {
  id: number;
  title: string;
  price: number;
  pictureUrl: string;
  address: string;
  description: string;
  isApproved: boolean;
  advertDate: Date;
  categoryName: string;
  categoryDescription: string;
}
