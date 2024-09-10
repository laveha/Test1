using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Paswords.Tests
{
    [TestClass]
    public class PasswTests
    {
        [TestMethod]
        public void Test_Password_Stroch()
        {
            string password = "abcABC";
            int expectedScore = 1;
            Assert.AreEqual(expectedScore, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void Test_Password_Stroch_Number()
        {
            string password = "abc123";
            int expectedScore = 2;
            Assert.AreEqual(expectedScore, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void Test_Password_Stroch_Num_Zaglav()
        {
            string password = "abc123ABC";
            int expectedScore = 3;
            Assert.AreEqual(expectedScore, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void Test_Password_Stroch_Num_Zaglav_Spez()
        {
            string password = "abc123ABC@";
            int expectedScore = 4;
            Assert.AreEqual(expectedScore, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void Test_Password_Stroch_Num_Zaglav_Spez_Dlin()
        {
            string password = "abc123ABC@123456";
            int expectedScore = 5;
            Assert.AreEqual(expectedScore, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void Test_Password_Net_Sootvetstvii()
        {
            string password = "aaa";
            int expectedScore = 0;
            Assert.AreEqual(expectedScore, Passw.CheckPasw(password));
        }
    }
}
