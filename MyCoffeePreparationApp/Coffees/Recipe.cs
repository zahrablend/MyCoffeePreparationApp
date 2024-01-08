using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeePreparationApp.Coffees
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients { get; }
        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            var preparationSteps = new List<string>();
            foreach(var ingredient in Ingredients)
            {
                preparationSteps.Add($"{ingredient.Name}. {ingredient.Instructions}");
            }

            return string.Join(Environment.NewLine, preparationSteps);
        }
    }
}
