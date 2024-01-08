using MyCoffeePreparationApp.Coffees;

namespace MyCoffeePreparationApp.App
{
    public class CoffeePreparationApp
    {
        private readonly ICoffeesRepository _coffeesRepository;
        private readonly IRecipesUserInteraction _recipesUserInteraction;

        public CoffeePreparationApp(
            ICoffeesRepository coffeesRepository,
            IRecipesUserInteraction recipesUserInteraction)
        {
            _coffeesRepository = coffeesRepository;
            _recipesUserInteraction = recipesUserInteraction;
        }

        public void Run(string filePath)
        {
            var allRecipes = _coffeesRepository.Read(filePath);
            _recipesUserInteraction.PrintCoffeeRecipes(allRecipes);

            _recipesUserInteraction.PromptToCreateRecipe();

            var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

            if (ingredients.Any())
            {
                var recipe = new Recipe(ingredients);
                allRecipes.Add(recipe);
                _coffeesRepository.Write(filePath, allRecipes);

                _recipesUserInteraction.ShowMessage("Recipe added:");
                _recipesUserInteraction.ShowMessage(recipe.ToString());
            }
            else
            {
                _recipesUserInteraction.ShowMessage
                    (
                    "No ingredients have been selected. " +
                    "Recipe will not be saved.");
            }

            _recipesUserInteraction.Exit();
        }
    }
}
