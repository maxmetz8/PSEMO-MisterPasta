import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-best-seller-item',
  templateUrl: './best-seller-item.component.html',
  styleUrl: './best-seller-item.component.css'
})
export class BestSellerItemComponent {
  @Input() image: string = "";
  @Input() information: string = "";
  @Input() product: string = "";
  constructor(
    private router: Router
  ) { }

  onChoose() {
    this.router.navigate(['/order']);
  }
}
