"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ProductService = void 0;
var product_1 = require("../domain/product");
var faker_1 = require("@faker-js/faker");
var ProductService = /** @class */ (function () {
    function ProductService() {
        this.updateQuality = function (products) {
        };
    }
    ProductService.prototype.generateProducts = function (numberProducts) {
        var products = [];
        for (var i = 0; i < numberProducts; i++) {
            products.push(new product_1.Product(faker_1.faker.commerce.product(), getRandomBetween(0, 50), getRandomBetween(0, 50)));
        }
        return products;
    };
    return ProductService;
}());
exports.ProductService = ProductService;
