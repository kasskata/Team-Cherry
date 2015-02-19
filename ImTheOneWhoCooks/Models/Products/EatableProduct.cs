﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ImTheOneWhoCooks.Contracts;
using ImTheOneWhoCooks.Enums;

namespace ImTheOneWhoCooks.Models.Products
{
    public class EatableProduct : Product, ICaloriable
    {
        private int calories;

        public EatableProduct(string name, decimal price, double quantity, UnitOfMeasurement unitOfMeasurement, ProductType productType, int calories) : 
            base(name, price, quantity, unitOfMeasurement, productType)
        {
            this.Calories = calories;
        }

        public int Calories
        {
            get { return calories; }
            set { calories = value; }
        }
    }
}
