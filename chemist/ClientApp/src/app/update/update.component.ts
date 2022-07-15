import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Product } from '../models/Product';
import { ProductService } from '../services/ProductService';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {

  id:string | null;
  product = new Product();
  constructor(private route: ActivatedRoute,
              private productService:ProductService) { 
    this.id = '';
  }

  ngOnInit(): void {
    this.id = this.route.snapshot.queryParamMap.get("id");
    if(this.id!=null)
    {
      this.productService.Get(+this.id).subscribe((res:Product)=>{
        this.product = res;
      });
    }
  
  }

  Save()
  {
    this.productService.Update(this.product).subscribe(res=>{});
  }


}
