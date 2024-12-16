import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Meal } from '../../../models/Meal';
import { firstValueFrom } from 'rxjs';
import { CartService } from './cartService';

@Injectable({
  providedIn: 'root',
})
export class CartCalculationService {
  constructor(private httpClient: HttpClient, private cartService: CartService) { }

  async calculateTotalProductsPrice(): Promise<number> {
    const cartItems = this.cartService.cartItemsSubject.value; // Get the latest cart state

    let totalProductPrice = 0;

    for (const cartItem of cartItems) {
      try {
        const response = await firstValueFrom(
          this.httpClient.get<Meal>(`https://localhost:7191/api/Products/${cartItem.productId}`)
        );
        totalProductPrice += response.price * cartItem.quantity;
      } catch (error) {
        console.error(`Failed to fetch price for product ${cartItem.productId}`, error);
      }
    }

    return totalProductPrice;
  }
}
