using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObject
{
    class StringAndObject
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";

            object text = a + " " + b;
            Console.WriteLine(text);

            string c = (string)text;
            Console.WriteLine(c);
        }
    }
}
