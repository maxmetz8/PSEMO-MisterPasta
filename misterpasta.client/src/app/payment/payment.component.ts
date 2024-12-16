import { Component, OnInit } from '@angular/core';
import { CartCalculationService } from '../services/cartCalculationService';


@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrl: './payment.component.css'
})
export class PaymentComponent implements OnInit {
  totalProductPrice: number;

  constructor(private cartCalculationService: CartCalculationService) {}

  ngOnInit(): void {
    this.getTotalPrice();
  }

  createPayment(form: any) {
    console.warn(form);
  }

  private async getTotalPrice(): Promise<void> {
    this.totalProductPrice = await this.cartCalculationService.calculateTotalProductsPrice();
  }

  isValidDutchPhoneNumber(phoneNumber: string): boolean {
    const dutchPhoneRegex = /^0[1-9][0-9]{1}[0-9]{8}$/;
    return dutchPhoneRegex.test(phoneNumber);
  }

  isValidEmail(email: string): boolean {
    const emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    return emailRegex.test(email);
  }

  isValidPostalCode(postalcode: string): boolean {
    const postalcodeRegex = /^[1-9][0-9]{3}\s?[A-Z]{2}$/;
    return postalcodeRegex.test(postalcode);
  }
}

