export class Image {
  public ImageId: number;
  public ProductId: number;
  public ImageUrl: string;
  

  constructor(ImageId: number, ProductId: number, ImageUrl: string) {
    this.ImageId = ImageId;
    this.ProductId = ProductId;
    this.ImageUrl = ImageUrl;
  }
}
