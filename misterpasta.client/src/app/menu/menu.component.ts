import { Component, OnInit } from '@angular/core';
import { ShareAmountService } from '../order/share-amount.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent implements OnInit {
  minimumAmount: number = 0;

  constructor(private sharedDataService: ShareAmountService) { }

  ngOnInit() {
    this.sharedDataService.minimumAmount$.subscribe((amount: number) => {
      this.minimumAmount = amount;
    });
  }
}
