using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyCoffeePreparationApp.DataAccess
{
    public class StringsXmlRepository : StringsRepository
    {
        protected override string StringsToText(List<string> data)
        {
            var xmlDoc = new XDocument(new XElement("data", data.Select(s => new XElement("string", s))));
            return xmlDoc.ToString();
        }

        protected override List<string> TextToStrings(string fileContents)
        {
            var xmlDoc = XDocument.Parse(fileContents);
            return xmlDoc.Root.Elements("string").Select(e => e.Value).ToList();
        }
    }
}
