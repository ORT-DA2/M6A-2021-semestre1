import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductListComponent } from './components/product-list/product-list.component';
import { ProductRowComponent } from './components/product-row/product-row.component';
import { FormsModule } from '@angular/forms';
import { FilterPipe } from './components/product-list/pipes/filter.pipe';
import { ProductDetailComponent } from './components/product-detail/product-detail.component';
import { ProductNotExistGuard } from './components/product-detail/guards/product-not-exist.guard';

@NgModule({
  declarations: [
    AppComponent,
    ProductListComponent,
    ProductRowComponent,
    FilterPipe,
    ProductDetailComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [ProductNotExistGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
