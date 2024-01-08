using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeePreparationApp.Coffees.Ingredients
{
    public abstract class CoffeeBean : Ingredient
    {
        public override string Instructions => $"Grind. {base.Instructions}";
    }
}
