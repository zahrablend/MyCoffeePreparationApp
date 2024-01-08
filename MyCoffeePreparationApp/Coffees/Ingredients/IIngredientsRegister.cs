using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeePreparationApp.Coffees.Ingredients
{
    public interface IIngredientsRegister
    {
        IEnumerable<Ingredient> All { get; }
        Ingredient GetById(int id);
    }
}
