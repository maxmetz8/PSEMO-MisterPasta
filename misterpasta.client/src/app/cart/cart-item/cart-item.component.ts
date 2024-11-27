import { Component, Input } from '@angular/core';
import { Meal } from '../../../../models/Meal';

@Component({
  selector: 'app-cart-item',
  templateUrl: './cart-item.component.html',
  styleUrl: './cart-item.component.css'
})
export class CartItemComponent {
  @Input() meal: Meal;
  @Input() currentAmount: number;

  addAmount() {
    if (this.currentAmount < 99) {
      this.currentAmount++;
    }
  }

  subtractAmount() {
    if (this.currentAmount > 0) {
      this.currentAmount--;
    }
  }
 }
