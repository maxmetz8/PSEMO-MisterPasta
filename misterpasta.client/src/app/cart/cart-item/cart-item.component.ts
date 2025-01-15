import { Component, Input, OnInit } from '@angular/core';
import { Meal } from '../../../../models/Meal';
import { CartService } from '../../services/cartService';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-cart-item',
  templateUrl: './cart-item.component.html',
  styleUrls: ['./cart-item.component.css']
})
export class CartItemComponent implements OnInit {
  @Input() meal: Meal; 
  @Input() currentAmount: number;
  imageUrl: string = ''; 

  constructor(private cartService: CartService, private http: HttpClient) { }

  ngOnInit() {
    this.loadImage();
  }

  
  loadImage() {
    const productId = this.meal.productId;
    this.http
      .get<string[]>(`https://jg4c0gww4kwk8c4ocg8ckss0.145.44.234.98.sslip.io/api/Products/${productId}/images`)
      .subscribe({
        next: (images) => {
          if (images && images.length > 0) {
            this.imageUrl = images[0]; 
          } else {
            this.imageUrl = 'assets/placeholder.jpg'; 
          }
        },
        error: (err) => {
          console.error('Error fetching image:', err);
          this.imageUrl = 'assets/placeholder.jpg'; 
        }
      });
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
