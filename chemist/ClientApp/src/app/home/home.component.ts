import { Component } from '@angular/core';
import { Product } from '../models/Product';
import { ProductService } from '../services/ProductService';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public products = new Array<Product>();  
  /**
   *
   */
  constructor(private productService: ProductService) {    
     this.load()
  }

  ngOnInit() {
    this.productService.GetRange(0,10).subscribe((res:Array<Product>)=>{
      this.products = res;
    });
  }

  public Add(product:Product)
  {
      this.productService.Insert(product);
  }

  public delete(product:Product)
  {
    this.productService.Delete(product).subscribe(()=>{
      this.load();
    });    
  }

  load()
  {
    this.productService.GetRange(0,10).subscribe((res:Array<Product>)=>{
      this.products = res;
    });
  }
}
