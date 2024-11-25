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
import { MealComponent } from './menu/meal/meal.component';
import { FilterComponent } from './menu/filter/filter.component';
import { CounterComponent } from './menu/counter/counter.component';
import { FormsModule } from '@angular/forms';
import { InfoSectionOneComponent } from './home/info-section-one/info-section-one.component';
import { InfoSectionTwoComponent } from './home/info-section-two/info-section-two.component';


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
    MealComponent,
    FilterComponent,
    CounterComponent,
    InfoSectionOneComponent,
    InfoSectionTwoComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, FormsModule
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
