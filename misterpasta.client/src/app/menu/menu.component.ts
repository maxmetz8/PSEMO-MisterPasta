import { HttpClient } from '@angular/common/http';
import { Component, OnInit, inject } from '@angular/core';
import { Meal } from '../../../models/Meal';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent implements OnInit {
  meals: Meal[] = [];
  constructor(private httpClient: HttpClient) {}

  ngOnInit(): void {
    this.fetchProducts();
  }

  fetchProducts() {
    this.httpClient.get<Meal[]>('https://localhost:7191/api/Products').subscribe(
      (data) => {
        this.meals = data;
      },
      (error) => {
        console.log(error);
      }
    )
  }

  onMealsFiltered(filteredMeals: Meal[]) {
    this.meals = filteredMeals;
    console.log('Menu updated with filtered meals:', this.meals);
  }
}
