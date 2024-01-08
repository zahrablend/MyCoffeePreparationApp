using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeePreparationApp.Coffees.Ingredients
{
    public class ChocolatePowder : Ingredient
    {
        public override int Id => 8;

        public override string Name => "Chocolate Powder";

        public override string Instructions => "Sprinkle on top.";
    }
}
