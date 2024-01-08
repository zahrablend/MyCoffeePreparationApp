using MyCoffeePreparationApp.Coffees;
using MyCoffeePreparationApp.Coffees.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeePreparationApp.App
{
    public class RecipesConsoleUserInteraction : IRecipesUserInteraction
    {
        private readonly IIngredientsRegister _ingredientsRegister;

        public RecipesConsoleUserInteraction(
            IIngredientsRegister ingredientsRegister)
        {
            _ingredientsRegister = ingredientsRegister;
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void Exit()
        {
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        public void PrintCoffeeRecipes(IEnumerable<Recipe> allRecipes)
        {
            if (allRecipes.Any())
            {
                Console.WriteLine($"Available coffee recipes to prepare: " +
                    $"{Environment.NewLine}");

                var counter = 1;
                foreach (var recipe in allRecipes)
                {
                    Console.WriteLine($"===== {counter} =====");
                    Console.WriteLine(recipe);
                    Console.WriteLine();
                    ++counter;
                }
            }
        }

        public void PromptToCreateRecipe()
        {
            Console.WriteLine("Create a new coffee preparation recipe!" + 
                "List of available ingredients:");

            foreach (var ingredient in _ingredientsRegister.All)
            {
                Console.WriteLine(ingredient);
            }
        }

        public IEnumerable<Ingredient> ReadIngredientsFromUser()
        {
            bool shallStop = false;
            var ingredients = new List<Ingredient>();

            while(!shallStop)
            {
                Console.WriteLine("Add an ingredient by its ID, " +  
                    "or type anything else if finished.");

                var userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int id))
                {
                    var selectedIngredient = _ingredientsRegister.GetById(id);
                    if (selectedIngredient is not null)
                    {
                        ingredients.Add(selectedIngredient);
                    }
                }
                else
                {
                    shallStop = true;
                }
            }

            return ingredients;
        }
    }
}
