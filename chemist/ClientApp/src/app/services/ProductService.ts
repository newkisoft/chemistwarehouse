import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Product } from "../models/Product";

@Injectable()
export class ProductService {
    /**
     *
     */
    constructor(private http: HttpClient) {
        
    }

    public Insert(product:Product)
    {
        return this.http.post("/chemist/", product);
    }

    public Get(id:number)
    {
        return this.http.get<Product>('/chemist/'+id);
    }

    public GetRange(start:number, numberOfItems:number)
    {
        return this.http.get<Array<Product>>('/chemist/'+start+'/'+numberOfItems);
    }

    public Update(product:Product)
    {
        return this.http.put("/chemist/",product);
    }

    public Delete(product:Product)
    {
        return this.http.delete("/chemist/"+product.id);
    }

}