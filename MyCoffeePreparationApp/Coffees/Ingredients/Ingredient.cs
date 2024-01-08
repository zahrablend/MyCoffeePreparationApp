using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeePreparationApp.Coffees.Ingredients
{
    public abstract class Ingredient
    {
         public abstract int Id { get; }
        public abstract string Name { get; }
        public virtual string Instructions => 
            $"Add to a cup";

        public override string ToString() =>
            $"{Id}. {Name}";
    }
}
