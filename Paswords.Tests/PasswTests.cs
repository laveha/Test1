using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Paswords.Tests
{
    [TestClass]
    public class PasswTests
    {
        [TestMethod]
        public void Test_Password_Stroch()
        {
            //arrange
            string password = "abc";
            int expected = 1;
            //assert
            Assert.AreEqual(expected, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void Test_Password_Stroch_Number()
        {
            string password = "abc123";
            int expected = 2;
            //assert
            Assert.AreEqual(expected, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void Test_Password_Stroch_Num_Zaglav()
        {
            string password = "abc123ABC";
            int expected = 3;
            //assert
            Assert.AreEqual(expected, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void Test_Password_Stroch_Num_Zaglav_Spez()
        {
            string password = "abc123ABC@";
            int expected = 4;
            //assert
            Assert.AreEqual(expected, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void Test_Password_Stroch_Num_Zaglav_Spez_Dlin()
        {
            string password = "abc123ABC@123456";
            int expected = 5;
            //assert
            Assert.AreEqual(expected, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void Test_Password_Net_Sootvetstvii()
        {
            //arrange
            string password = "";
            int expected = 0;
            //assert
            Assert.AreEqual(expected, Passw.CheckPasw(password));
        }
    }
}
