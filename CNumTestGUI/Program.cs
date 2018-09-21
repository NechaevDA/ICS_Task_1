using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICS_Task_1;

namespace CNumTestGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            var CNP = new ContractNumberParser();
            bool res = false;
            try
            {
                while (inp != "e")
                {
                    res = CNP.checkNumber(inp);
                    Console.WriteLine(res ? "Pass" : "Fail");
                    Console.Write("Print number: ");
                    inp = Console.ReadLine();
                }
            } catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
    }
}
