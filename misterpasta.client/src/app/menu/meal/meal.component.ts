import { Component, Input, OnInit } from '@angular/core';
import { Meal } from '../../../../models/Meal';

@Component({
  selector: 'app-meal',
  templateUrl: './meal.component.html',
  styleUrl: './meal.component.css'
})
export class MealComponent {
  @Input() meal: Meal;
  amount: number = 0;
  constructor() {
    this.meal = new Meal("Pasta bolognese", "8,99");
  }

  addAmount() {
    if (this.amount < 99 ) {
        this.amount++;
    }
  }

  subtractAmount() {
    if (this.amount > 0) {
        this.amount--;
    }
  }
}
