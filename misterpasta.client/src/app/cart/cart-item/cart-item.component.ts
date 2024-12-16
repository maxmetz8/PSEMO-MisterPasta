import { Component, Input } from '@angular/core';
import { Meal } from '../../../../models/Meal';
import { CartService } from '../../services/cartService';

@Component({
  selector: 'app-cart-item',
  templateUrl: './cart-item.component.html',
  styleUrl: './cart-item.component.css'
})
export class CartItemComponent {
  @Input() meal: Meal;
  @Input() currentAmount: number;

  constructor(private cartService: CartService) {

  }

  addAmount() {
    if (this.currentAmount < 99) {
      this.currentAmount++;
      this.cartService.addToCart(this.meal, 1);
    }
  }

  subtractAmount() {
    if (this.currentAmount > 1) {
      this.currentAmount--;
      this.cartService.addToCart(this.meal, -1);
    }
  }

  removeItem() {
    this.cartService.removeCartItem(this.meal);
  }
 }
