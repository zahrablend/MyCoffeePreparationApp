namespace MyCoffeePreparationApp.DataAccess
{
    public abstract class StringsRepository : IStringsRepository
    {
        public List<string> Read(string filePath)
        {
            var fileContents = File.ReadAllText(filePath);
            return TextToStrings(fileContents);
        }

        protected abstract List<string> TextToStrings(string fileContents);

        public void Write(string filePath, List<string> data)
        {
            File.WriteAllText(filePath, StringsToText(data));
        }

        protected abstract string StringsToText(List<string> data); 
    }
}
