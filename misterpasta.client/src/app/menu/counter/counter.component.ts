import { Component } from '@angular/core';
import { ShareAmountService } from '../share-amount.service';

@Component({
  selector: 'app-counter',
  templateUrl: './counter.component.html',
  styleUrl: './counter.component.css'
})
export class CounterComponent {
  minimumAmount: number = 0;
  sliderValue: number = 0;
  constructor(private sharedDataService: ShareAmountService) { }

  ngOnInit() {
    this.sharedDataService.minimumAmount$.subscribe((amount: number) => {
      localStorage.setItem('minimum amount', this.minimumAmount.toString());
    });
  }

  setMinimumAmount() {
    
  }
}
