﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImTheOneWhoCooks.Models.Recipes
{
    public class DrinkableRecipe : Recipe
    {
        public DrinkableRecipe(string name, decimal price) 
            : base(name, price)
        {
        }

        public override string Cook()
        {
            throw new NotImplementedException();
        }
    }
}
