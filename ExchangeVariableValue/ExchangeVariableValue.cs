using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValue
{
    class ExchangeVariableValue
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a:{0}\nb:{1}", a, b);
            Console.WriteLine("a:{1}\nb:{0}", a, b);
        }
    }
}
