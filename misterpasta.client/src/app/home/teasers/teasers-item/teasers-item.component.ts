import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-teasers-item',
  templateUrl: './teasers-item.component.html',
  styleUrl: './teasers-item.component.css'
})
export class TeasersItemComponent {
  @Input() image: string = "";
  @Input() information: string = "";
  @Input() product: string = "";
}
