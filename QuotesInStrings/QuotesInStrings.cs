using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string without = "The \"use\" of quotations causes difficulties.";
            string with = "\"The \"use\" of quotations causes difficulties.\"";
            Console.WriteLine(without);
            Console.WriteLine(with);
        }
    }
}
