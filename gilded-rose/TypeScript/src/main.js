"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var product_service_1 = require("./service/product-service");
var s = new product_service_1.ProductService();
var products = s.generateProducts(30);
console.log(products);
