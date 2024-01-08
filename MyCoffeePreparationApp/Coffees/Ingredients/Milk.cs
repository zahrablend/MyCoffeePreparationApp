using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeePreparationApp.Coffees.Ingredients
{
    public partial class Milk : Ingredient
    {
        public override int Id => 3;
        public override string Name => "Milk";
        public override string Instructions => 
            $"warm up required amount according to a cup size. {base.Instructions}";
    }
}
