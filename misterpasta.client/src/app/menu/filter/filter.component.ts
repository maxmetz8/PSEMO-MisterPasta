import { Component } from '@angular/core';
import { Meal } from '../../../../models/Meal';

@Component({
  selector: 'app-filter',
  templateUrl: './filter.component.html',
  styleUrls: ['./filter.component.css']
})
export class FilterComponent {
  sliderValue: number = 30;

  vegetarianChecked: boolean = false;
  veganChecked: boolean = false;
  halalChecked: boolean = false;


  filterProducts(): Meal[] {


  }
}
