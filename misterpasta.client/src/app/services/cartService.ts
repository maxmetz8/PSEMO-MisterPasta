import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Meal } from '../../../models/Meal';

@Injectable({
  providedIn: 'root',
})
export class CartService {
  public cartItemsSubject = new BehaviorSubject<Meal[]>(this.getStoredCartItems());
  cartItems$ = this.cartItemsSubject.asObservable(); // Expose as observable

  constructor() { }

  addToCart(meal: Meal, quantity: number): void {
    const mealId = meal.productId.toString();
    const storedMeal = this.getStoredMeal(mealId);

    if (storedMeal) {
      this.increaseAmount(storedMeal, quantity);
      this.saveMeal(mealId, storedMeal);
    } else {
      meal.quantity = quantity; // Set initial quantity
      this.saveMeal(mealId, meal);
    }
    this.updateCartItems();
  }

  removeCartItem(meal: Meal): void {
    localStorage.removeItem(meal.productId.toString());
    this.updateCartItems();
  }

  private updateCartItems(): void {
    // Emit updated cart items
    this.cartItemsSubject.next(this.getStoredCartItems());
  }

  private increaseAmount(meal: Meal, quantity: number): void {
    const maxQuantity = 99;
    meal.quantity = Math.min(meal.quantity + quantity, maxQuantity);
  }

  private getStoredCartItems(): Meal[] {
    return Object.entries(localStorage)
      .map(([key, value]) => {
        try {
          return JSON.parse(value) as Meal; // Safely parse each item
        } catch {
          return null; // Ignore invalid data
        }
      })
      .filter((item): item is Meal => !!item); // Filter out null values
  }

  private getStoredMeal(mealId: string): Meal | null {
    const storedMeal = localStorage.getItem(mealId);
    return storedMeal ? JSON.parse(storedMeal) as Meal : null;
  }

  private saveMeal(mealId: string, meal: Meal): void {
    localStorage.setItem(mealId, JSON.stringify(meal));
  }
}
