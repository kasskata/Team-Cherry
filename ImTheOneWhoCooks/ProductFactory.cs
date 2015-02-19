﻿using ImTheOneWhoCooks.Contracts;
using ImTheOneWhoCooks.Contracts.Factories;
using ImTheOneWhoCooks.Enums;
using ImTheOneWhoCooks.Models.Products;

namespace ImTheOneWhoCooks
{
    public class ProductFactory :IProductFactory
    {
        public IProduct CreatProduct(string name, decimal price, double quantity, UnitOfMeasurement unitOfMeasurement,
            ProductType productType)
        {
            return new Product(name, price, quantity, unitOfMeasurement, productType);
        }

        public IProduct CreatEatableProduct(string name, decimal price, double quantity, UnitOfMeasurement unitOfMeasurement,
            ProductType productType, int calories)
        {
            return new EatableProduct(name, price, quantity, unitOfMeasurement, productType, calories);
        }
    }
}