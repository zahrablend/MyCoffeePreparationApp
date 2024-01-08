using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeePreparationApp.Coffees.Ingredients
{
    public abstract class Spice : Ingredient
    {
        public override string Name =>
            $"Take one teaspoon. {base.Instructions}";
    }
}