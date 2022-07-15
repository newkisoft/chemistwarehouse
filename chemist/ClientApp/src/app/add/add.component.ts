import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from '../models/Product';
import { ProductService } from '../services/ProductService';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit {

  product = new Product();

  constructor(private  productService:ProductService,private router: Router) { }

  ngOnInit(): void {
  }

  Save()
  {
    this.productService.Insert(this.product).subscribe(res=>{});
    this.router.navigate(['/']);
  }

}
