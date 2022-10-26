import {ProductService} from "./service/product-service";
import {Product} from "./domain/product";

const s: ProductService = new ProductService();
const products : Array<Product> = s.generateProducts(30);
console.log(products);
