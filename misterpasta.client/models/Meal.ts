export class Meal {
  public productId: number;
  public name: string;
  public description: string;
  public price: number;
  public largeDescription: string;
  public quantity: number;

  constructor(productId: number, name: string, description: string, price: number, largeDescription: string, quantity: number) {
    this.productId = productId;
    this.name = name;
    this.description = description;
    this.price = price;
    this.largeDescription = largeDescription;
    this.quantity = quantity;
  }
}
