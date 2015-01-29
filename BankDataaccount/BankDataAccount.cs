using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataaccount
{
    class BankDataAccount
    {
        static void Main(string[] args)
        {
            string firstName = "Boriana";
            string middleName = "Nikolava";
            string lastName = "Krusteva";
            long bankCount = 23452312324;
            string bankName = "FIB";
            string iban = "FIB11111";
            object firstCardNumber = "EA2323232";
            object secondCardNumber = "FA1234567";
            object thirdNumber = "SA8765432";

            Console.WriteLine(" first name: {0} \n middle name: {1} \n last name: {2} \n bank count: {3} \n bank name: {4} \n IBAN: {5} \n first card number: {6} \n second card number: {7} \n third card number: {8}"
                , firstName, middleName, lastName, bankCount, bankName, iban, firstCardNumber, secondCardNumber, thirdNumber);
        }
    }
}
