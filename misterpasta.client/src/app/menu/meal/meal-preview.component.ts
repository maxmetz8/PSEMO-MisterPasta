import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { Meal } from '../../../../models/Meal';
import { CartService } from '../../services/cartService';

@Component({
  selector: 'app-meal-preview',
  templateUrl: './meal-preview.component.html',
  styleUrls: ['./meal-preview.component.css']
})
export class MealPreviewComponent implements OnInit {
  @Input() meal: Meal = new Meal(0, '', '', 0, '', 1);
  imageUrl: string = ''; 

  constructor(private cartService: CartService, private http: HttpClient) { }

  ngOnInit() {
    console.log('Meal input initialized:', this.meal);
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
            this.imageUrl = 'assets/placeholder.jpg'; // Placeholder indien geen afbeeldingen
          }
        },
        error: (err) => {
          console.error('Error fetching image:', err);
          this.imageUrl = 'assets/placeholder.jpg'; // Placeholder bij een fout
        }
      });
  }

  addAmount() {
    if (this.meal.quantity < 99) {
      this.meal.quantity++;
    }
  }

  subtractAmount() {
    if (this.meal.quantity > 1) {
      this.meal.quantity--;
    }
  }

  addToCart() {
    this.cartService.addToCart(this.meal, this.meal.quantity);
    alert(
      'Succesvol ' +
      this.meal.quantity +
      ' keer ' +
      this.meal.name +
      ' toegevoegd!'
    );
  }
}
