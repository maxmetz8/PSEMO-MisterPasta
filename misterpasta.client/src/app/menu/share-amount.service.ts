import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ShareAmountService {

  private minimumAmountSource = new BehaviorSubject<number>(0);
  minimumAmount$ = this.minimumAmountSource.asObservable();

  setMinimumAmount(amount: number) {
    this.minimumAmountSource.next(amount);
  }
}
