﻿using System; using System.Collections.Generic; using System.Linq; using System.Text;  namespace ImTheOneWhoCooks.Models.Recipes {     public class GrilledRecipe : RawRecipe     {         public GrilledRecipe(string name, decimal price, int preparingTime)              : base(name, price, preparingTime)         {         }          public override string Cook()         {             throw new NotImplementedException();         }     } } 