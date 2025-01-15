import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Image } from '../../../../../models/Image';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-image-selector',
  templateUrl: './image-selector.component.html',
  styleUrls: ['./image-selector.component.css']
})
export class ImageSelectorComponent implements OnInit {
  pictures: string[] = [];
  savedPictureIdx: number = -1;
  images: Image[] = [];
  constructor(private httpClient: HttpClient, private route: ActivatedRoute) { }

  ngOnInit(): void {
    const productId = Number(this.route.snapshot.paramMap.get('id')); // Product ID uit de route
    this.fetchImages(productId);
  }

  fetchImages(productId: number) {
      this.httpClient.get<string[]>(`https://jg4c0gww4kwk8c4ocg8ckss0.145.44.234.98.sslip.io/api/Products/${productId}/images`)
      .subscribe(
        (data) => {
          this.pictures = data; // Vul de lijst met afbeeldingen
          if (this.pictures.length > 0) {
            this.savedPictureIdx = 0; // Selecteer standaard de eerste afbeelding
          }
        },
        (error) => {
          console.error("Error fetching images: ", error);
        }
      );
  }



  updatePicture(idx: number): void {
    this.savedPictureIdx = idx;
  }
}
