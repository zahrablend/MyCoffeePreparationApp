using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeePreparationApp.Coffees.Ingredients
{
    public class IngredientsRegister : IIngredientsRegister
    {
        public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
        {
            new Arabica(),
            new Robusta(),
            new Milk(),
            new Cream(),
            new Sugar(),
            new Cinnamon(),
            new Cardamom(),
            new ChocolatePowder(),
        };

        public Ingredient GetById(int id)
        {
            foreach (var ingredient in All)
            {
                if (ingredient.Id == id)
                {
                    return ingredient;
                }
            }

            return null;
        }
    }
}
