using MyCoffeePreparationApp.DataAccess;

namespace MyCoffeePreparationApp.Coffees
{
    public class RecipesRepository : ICoffeesRepository
    {
        private readonly IStringsRepository _stringsRepositoty;
        private readonly IIngredientsRegister _ingredientsRegister;
        private const string Separator = ",";
        public RecipesRepository(
            IStringsRepository stringsRepository,
            IIngredientsRegister ingredientsRegister))
        {
            _stringsRepository = stringsRepository;
            _ingredientsRegister = ingredientsRegister;
        }

        public List<Recipe> Read(string filePath)
        {
        List<string> recipesFromFile = _stringsRepository.Read(filePath);
        var recipes = new List<Recipe>();

        foreach (var recipeFromFile in recipesFromFile)
        {
            var recipe = RecipeFromString(recipeFromFile);
            recipes.Add(recipe);
        }

        return recipes;
    }
}
