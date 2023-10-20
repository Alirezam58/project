using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.core.Classes
{
    public class CodeGenerator
    {
        public static string GenerateCode()
        {
            Random random = new Random();
            return random.Next(100000,999999).ToString();
        }

        public static string GuidCode()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
