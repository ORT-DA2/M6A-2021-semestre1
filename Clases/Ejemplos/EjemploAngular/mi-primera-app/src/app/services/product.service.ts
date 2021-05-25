import { Injectable } from '@angular/core';
import { Product } from '../../models/product';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  constructor() {
    this.nextId = 1;
    this.products = this.initializateProducts();
  }

  products: Product[];
  nextId: number;

  getProducts() {
    return this.products;
  }

  deleteProduct(product: Product) {
    const id = this.products.indexOf(product, 0);
    if (id === -1) alert('No existe producto');
    else this.products.splice(id, 1);
  }

  getProduct(id: number) {
    return this.products.filter((p) => p.id == id)[0];
  }

  existProduct(id: number) {
    return this.products.filter(p => p.id == id).length > 0;
  }

  initializateProducts() {
    let tv = new Product('Smart TV', 600);
    tv.id = this.nextId;
    this.nextId++;
    let notebook = new Product('Notebook', 1400);
    notebook.id = this.nextId;
    this.nextId++;
    let keyboard = new Product('Teclado mécanico', 250);
    keyboard.id = this.nextId;
    this.nextId++;

    return new Array<Product>(tv, notebook, keyboard);
  }
}
