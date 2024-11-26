import { Component, EventEmitter, Output } from '@angular/core';
import { Meal } from '../../../../models/Meal';
import { HttpClient } from '@angular/common/http';
import { ProductRequestDTO } from '../../../../models/DTO/ProductRequestDTO';

@Component({
  selector: 'app-filter',
  templateUrl: './filter.component.html',
  styleUrls: ['./filter.component.css']
})
export class FilterComponent {
  maxPrice: number = 30;

  vegetarianChecked: boolean = false;
  veganChecked: boolean = false;
  halalChecked: boolean = false;

  @Output() filteredMeals = new EventEmitter<Meal[]>();

  constructor(private httpClient: HttpClient) { }

  filterProducts() {


    const request: ProductRequestDTO = {
      isVegetarian: this.veganChecked ? true: this.vegetarianChecked,
      isVegan: this.veganChecked,
      isHalal: this.vegetarianChecked || this.veganChecked ? true : this.halalChecked,
      maxPrice: this.maxPrice,
    };

    this.httpClient.post<Meal[]>('https://localhost:7191/api/Products/Filter', request)
      .subscribe(
        (response) => {
          this.filteredMeals.emit(response);
          console.log(request);
          console.log('Filtered meals:', response);
        },
        (error) => {
          console.error('Error while filtering products:', error);
        }
      );
  }
}
