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
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { OrderOptionComponent } from './order/order-option/order-option.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { MenuComponent } from './menu/menu.component';
import { MealPreviewComponent } from './menu/meal/meal-preview.component';
import { FilterComponent } from './menu/filter/filter.component';
import { CounterComponent } from './menu/counter/counter.component';
import { FormsModule } from '@angular/forms';
import { ProductPageComponent } from './menu/product-page/product-page.component';


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
    ProductPageComponent
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
