﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public void CheckName(string name)
        {
            string namePtr = "^[A-Z][a-z]{3,}$";
            if (Regex.IsMatch(name, namePtr))
            {
                Console.WriteLine("String is match the pattern");
            }
            else
            {
                Console.WriteLine("String is dose not match the pattern");
            }
        }
        public void CheckLastName(string lName)
        {
            string namePtr = "^[A-Z][a-z]{3,}$";
            if (Regex.IsMatch(lName, namePtr))
            {
                Console.WriteLine("String is match the pattern");
            }
            else
            {
                Console.WriteLine("String is dose not match the pattern");
            }
        }
        public void MoblieNo(string phoneNo)
        {
            string phPtr = "^[0-9]{2}[ ][0-9]{10}$";
            if (Regex.IsMatch(phoneNo, phPtr))
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
