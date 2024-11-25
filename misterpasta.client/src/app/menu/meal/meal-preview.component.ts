import { Component, Input, OnInit } from '@angular/core';
import { Meal } from '../../../../models/Meal';

@Component({
  selector: 'app-meal-preview',
  templateUrl: './meal-preview.component.html',
  styleUrl: './meal-preview.component.css'
})
export class MealPreviewComponent implements OnInit{
  @Input() meal: Meal = new Meal(0, '','', 0, '');
  amount: number = 0;

  ngOnInit() {
    console.log('Meal input initialized:', this.meal);
  }
  constructor() {
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
