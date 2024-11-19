import { Component, Input, OnInit } from '@angular/core';
import { Meal } from '../../../../models/Meal';

@Component({
  selector: 'app-meal-preview',
  templateUrl: './meal-preview.component.html',
  styleUrl: './meal-preview.component.css'
})
export class MealPreviewComponent {
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
