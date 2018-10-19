using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBusiness.Helpers
{
   public class FileHelpers
    {
        public static void WriteFile(string content, string fileName)
        {
            System.IO.File.WriteAllText(fileName, content);
        }
    }
}
