import { Component, Input, OnInit } from '@angular/core';
import { Meal } from '../../../../models/Meal';
import { CartService } from '../../services/cartService';

@Component({
  selector: 'app-meal-preview',
  templateUrl: './meal-preview.component.html',
  styleUrl: './meal-preview.component.css'
})
export class MealPreviewComponent implements OnInit{
  @Input() meal: Meal = new Meal(0, '','', 0, '', 1);

  ngOnInit() {
    console.log('Meal input initialized:', this.meal);
  }
  constructor(private cartService: CartService) {
  }

  addAmount() {
    if (this.meal.quantity < 99 ) {
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
    alert('succesvol ' + this.meal.quantity + ' keer ' + this.meal.name + ' toegevoegd!');
  }
}
