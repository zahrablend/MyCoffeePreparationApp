using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeePreparationApp.Coffees
{
    public interface ICoffeesRepository
    {
        List<Recipe> Read(string filePath);
        void Write(string filePath, List<Recipe> allRecipes);
    }
}
