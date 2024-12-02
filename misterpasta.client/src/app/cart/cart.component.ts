import { Component } from '@angular/core';
import { Meal } from '../../../models/Meal';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrl: './cart.component.css'
})
export class CartComponent {
    cartItems: Meal[];

  constructor() {

  }

  ngOnInit() {
    this.cartItems = new Array(
        new Meal(
                    1,
                    "Spaghetti Bolognese",
                    "Lange slierten spaghetti in een rijke saus van gehakt, tomaten, en kruiden. Een hartverwarmende klassieker die perfect is voor elke pasta-liefhebber.",
                    10.99,
                    "",
                    0
                ),
        new Meal(
                    2,
                    "Lasagne",
                    "Pittige penne met een kruidige tomatensaus.",
                    12.99,
                    "",
                    0
                ),
        new Meal(
                    3,
                    "Carbonara",
                    "Romige spaghetti zonder room, maar met een saus van eieren, Parmezaanse kaas en knapperige guanciale. De volle, romige smaak smelt op de tong.",
                    10.99,
                    "",
                    0
                ),
        new Meal(
                    4,
                    "Penne all’Arrabbiata",
                    "Pittige tomatensaus met knoflook en rode peper geeft deze penne een vurige kick. Ideaal voor wie van een beetje spice houdt!",
                    12.99,
                    "",
                    0
                ),
        new Meal(
                    5,
                    "Fettuccine Alfredo",
                    "Rijke en romige fettuccine, overgoten met een boterachtige Parmezaansaus die smelt in je mond. Het perfecte comfortfood voor een luxueuze traktatie.",
                    10.99,
                    "",
                    0
                )
    );
  }
}
