using System.Text.Json;

namespace MyCoffeePreparationApp.DataAccess
{
    public class StringsJsonRepository : StringsRepository
    {
        protected override string StringsToText(List<string> data) => 
            JsonSerializer.Serialize(data);

        protected override List<string> TextToStrings(string fileContents) => 
            JsonSerializer.Deserialize<List<string>>(fileContents);
    }
}
