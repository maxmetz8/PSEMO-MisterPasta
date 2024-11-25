export class Meal {
  public productId: number;
  public name: string;
  public description: string;
  public price: number;
  public largeDescription: string;

  constructor(productId: number, name: string, description: string, price: number, largeDescription: string) {
    this.productId = productId;
    this.name = name;
    this.description = description;
    this.price = price;
    this.largeDescription = largeDescription;
  }
}
