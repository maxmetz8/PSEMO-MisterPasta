import { Component, OnInit } from '@angular/core';
import { Meal } from '../../../models/Meal';
import { CartService } from '../services/cartService';
import { CartCalculationService } from '../services/cartCalculationService';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {
  cartItems: Meal[] = [];
  totalProductPrice: number = 0;
  shippingCost: number = 1.99;

  constructor(private cartService: CartService, private cartCalculationService: CartCalculationService) { }

  ngOnInit(): void {
    // Subscribe to the cartItems$ observable
    this.cartService.cartItems$.subscribe((items) => {
      this.cartItems = items;
      this.updateTotalPrice();
    });
  }

  private async updateTotalPrice(): Promise<void> {
    this.totalProductPrice = await this.cartCalculationService.calculateTotalProductsPrice();
  }
}
