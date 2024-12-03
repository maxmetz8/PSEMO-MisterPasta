import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { heroBannerComponent } from './home/heroBanner/heroBanner.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { OrderComponent } from './order/order.component';
import { CartComponent } from './cart/cart.component';
import { OrderOptionComponent } from './order/order-option/order-option.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { MenuComponent } from './menu/menu.component';
import { MealPreviewComponent } from './menu/meal/meal-preview.component';
import { FilterComponent } from './menu/filter/filter.component';
import { CounterComponent } from './menu/counter/counter.component';
import { FormsModule } from '@angular/forms';
import { InfoSectionOneComponent } from './home/info-section-one/info-section-one.component';
import { ProductPageComponent } from './menu/product-page/product-page.component';
import { InfoSectionTwoComponent } from './home/info-section-two/info-section-two.component';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { BestSellersComponent } from './home/best-sellers/best-sellers.component';
import { BestSellerItemComponent } from './home/best-sellers/best-seller-item/best-seller-item.component';
import { CartItemComponent } from './cart/cart-item/cart-item.component';
import { TeasersComponent } from './home/teasers/teasers.component';
import { TeasersItemComponent } from './home/teasers/teasers-item/teasers-item.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    heroBannerComponent,
    AboutComponent,
    ContactComponent,
    OrderComponent,
    CartComponent,
    HeaderComponent,
    FooterComponent,
    OrderOptionComponent,
    MenuComponent,
    MealPreviewComponent,
    FilterComponent,
    CounterComponent,
    InfoSectionOneComponent,
    InfoSectionTwoComponent,
    ProductPageComponent,
    BestSellersComponent,
    BestSellerItemComponent,
    CartItemComponent,
    TeasersComponent,
    TeasersItemComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, FormsModule, HttpClientModule
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
