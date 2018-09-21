using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Data;
using System.Collections.Generic;

namespace ICS_Task_1
{  
    public class InvalidContractNumberException : Exception
    {
        public InvalidContractNumberException() { }

        public InvalidContractNumberException(string message) : base(message) { }
    }
    public class ContractNumberParser
    {
        public bool checkNumber(string number)
        {
            if (Regex.IsMatch(number, "^([0-9]{2})([А-Я]{2})([0-9]{6})$"))
            {
                return NumberExistsInDB(number);
            }
            else throw new InvalidContractNumberException("Неправильный номер договора");
        }

        private bool NumberExistsInDB(string number)
        {
            var res = DatabaseSim.getData().Exists(x => x == number);
            return res;   
        }
    }

    public static class DatabaseSim
    {
        public static List<string> getData()
        {
            List<string> res = new List<string>()
            {
                "00ЭЭ000000",
                "12АА123456", 
                "33ММ333333"
            };
            return res;
        }
    }
}
