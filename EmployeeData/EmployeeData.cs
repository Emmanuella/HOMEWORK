using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Nikolai";
            string lastName = "Nikolov";
            char gender = 'M';
            byte age = 32;
            long personIDnumber = 8306112507;
            long uniqueEmployeeNumber = 27560000;

            Console.WriteLine("firstName :{0} lastName :{1}\n gender :{2}\n age :{3}\n personIDnumner :{4}\n UniqueEmployeeNumber :{5}\n", firstName, lastName, gender, age, personIDnumber, uniqueEmployeeNumber);
        }
    }
}
