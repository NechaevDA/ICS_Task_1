using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ICS_Task_1;


namespace UnitTestProject
{
    [TestClass]
    public class ContractNumberTest
    {
        [TestMethod]
        public void ContractNumber_Valid_InDB_Success()
        {
            var CNP = new ContractNumberParser();

            var res = CNP.checkNumber("00ЭЭ000000");

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ContractNumber_Valid_NotInDB_Fail()
        {
            var CNP = new ContractNumberParser();

            var res = CNP.checkNumber("00КК000123");

            Assert.IsFalse(res);
        }

        [TestMethod]        
        [ExpectedException(typeof(InvalidContractNumberException))]
        public void ContractNumber_Invalid_Fail()
        {
            ContractNumberParser CNP = new ContractNumberParser();

            var res = CNP.checkNumber("аа00аааи");
            
        }
    }
}
