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
    this.httpClient.get<Meal[]>('http://jg4c0gww4kwk8c4ocg8ckss0.145.44.234.98.sslip.io/api/Products').subscribe(
      (data) => {
        this.meals = data;
      },
      (error) => {
        console.log(error);
      }
    )
  }
}
