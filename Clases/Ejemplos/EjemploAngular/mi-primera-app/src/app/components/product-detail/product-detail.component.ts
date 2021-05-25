import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Product } from '../../../models/product';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent {

  constructor(private currentRoute: ActivatedRoute, private productService: ProductService, private router: Router) {
    const id =  currentRoute.snapshot.params.id;
    this.product = productService.getProduct(id);
  }

  product: Product;

  back() {
    this.router.navigateByUrl('/');
  }

}
