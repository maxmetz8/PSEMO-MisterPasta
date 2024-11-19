import { Component } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Meal } from '../../../../models/Meal';

@Component({
  selector: 'app-product-page',
  templateUrl: './product-page.component.html',
  styleUrl: './product-page.component.css'
})
export class ProductPageComponent {
  meal: Meal = new Meal('', '');
  name: string = '';

  constructor(private route: ActivatedRoute) {
  }

  ngOnInit() {
    this.route.params.subscribe(
      (params: Params) => {
        this.name = params['name'];
        this.meal = new Meal('bolognese', '10,99');
      }
    );
  }
}
