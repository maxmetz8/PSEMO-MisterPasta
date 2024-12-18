import { Component, Input } from "@angular/core";
import { Router } from '@angular/router';
import { ShareAmountService } from "../../menu/share-amount.service";

@Component({
  selector: 'app-order-option',
  templateUrl: './order-option.component.html',
  styleUrls: ['./order-option.component.css']
})
export class OrderOptionComponent {
  @Input() amount: number = 0;
  @Input() information: string = "";
  @Input() delivery: string = "";
  @Input() imageUrl: string = ""; 

  constructor(
    private sharedDataService: ShareAmountService,
    private router: Router
  ) { }

  onChoose() {
    this.sharedDataService.setMinimumAmount(this.amount);
    this.router.navigate(['/menu']);
  }
}
