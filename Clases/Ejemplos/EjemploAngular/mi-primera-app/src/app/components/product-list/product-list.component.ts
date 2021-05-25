import { ChangeDetectorRef, Component } from '@angular/core';
import { ProductService } from '../../services/product.service';
import { Product } from '../../../models/product';
import { Router } from '@angular/router';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css'],
})
export class ProductListComponent {
  constructor(private productService: ProductService, private router: Router) {
    this.products = this.productService.getProducts();
    this.filterValue = '';
  }

  products: Product[];
  filterValue: string = '';

  deleteProduct(product: Product) {
    this.productService.deleteProduct(product);
  }

  onProductClick(product: Product) {
    this.router.navigate(['/product', product.id]);
  }
}
