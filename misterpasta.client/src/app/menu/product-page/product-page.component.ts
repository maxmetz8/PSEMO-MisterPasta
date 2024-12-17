import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Meal } from '../../../../models/Meal';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-product-page',
  templateUrl: './product-page.component.html',
  styleUrl: './product-page.component.css'
})
export class ProductPageComponent {
  meal: Meal;
  id: number = 0;
  amount: number = 0;
  constructor(private route: ActivatedRoute, private httpClient: HttpClient) {
  }

  ngOnInit() {
    this.route.params.subscribe(
      (params: Params) => {
        this.id = +params['id'];

        this.fetchProduct(this.id).subscribe(
          (data: Meal) => {
            this.meal = data;
          },
          (error) => {
            console.error('Error fetching meal:', error);
          }
        );
      }
    );
  }

  fetchProduct(id: number) {
      return this.httpClient.get<Meal>(`https://jg4c0gww4kwk8c4ocg8ckss0.145.44.234.98.sslip.io/api/Products/${this.id}`);
  }

  addAmount() {
    if (this.amount < 99) {
      this.amount++;
    }
  }

  subtractAmount() {
    if (this.amount > 0) {
      this.amount--;
    }
  }
}
