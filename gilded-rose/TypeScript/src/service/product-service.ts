import {Product} from "../domain/product";
import { faker } from '@faker-js/faker';

export class ProductService {
    generateProducts(numberProducts: number): Array<Product> {
        let products: Array<Product> = [];
        for (let i = 0; i < numberProducts; i++) {
            products.push(
                new Product(
                    faker.commerce.product(),
                    getRandomBetween(0, 50),
                    getRandomBetween(0, 50)
                )
            );
        }
        return products;
    }

    updateQuality = (products: Array<Product>) => {

    }
}