using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeePreparationApp.DataAccess
{
    public interface IStringsRepository
    {
        List<string> Read(string filePath);
        void Write(string filePath, List<string> data);
    }
}
