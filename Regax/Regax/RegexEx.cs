using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regax
{
    
    public class RegexEx
    {
        static string pattern = "^cen$";
        //^ It indicate string start.
        //$ it will indicate the end of the string.
        public void MyRegex()
        {
            //we have created object of class.
            //we have pass a parameter pattern in given class constrcyor.
            Regex regax = new Regex(pattern);
            if (regax.IsMatch("Amit"))
            {
                Console.WriteLine("String is match the pattern");
            }
            else
            {
                Console.WriteLine("String is dose not match the pattern");
            }
        }
    }
}
