using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Paswords.Tests
{
    [TestClass]
    public class PasswTests
    {
        [TestMethod]
        public void CheckPasw_PasswordWithLowercaseOnly_1Returned()
        {
            //arrange
            string password = "abc";
            int expected = 1;
            //assert
            Assert.AreEqual(expected, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void CheckPasw_PasswordWithLowercaseAndDigits_2Returned()
        {
            //arrange
            string password = "abc123";
            int expected = 2;
            //assert
            Assert.AreEqual(expected, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void CheckPasw_PasswordWithLowercaseDigitsAndUppercase_3Returned()
        {
            //arrange
            string password = "abc123ABC";
            int expected = 3;
            //assert
            Assert.AreEqual(expected, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void CheckPasw_PasswordWithLowercaseDigitsUppercaseAndSpecialChar_4Returned()
        {
            //arrange
            string password = "abc123ABC@";
            int expected = 4;
            //assert
            Assert.AreEqual(expected, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void CheckPasw_PasswordWithAllCriteria_5Returned()
        {
            //arrange
            string password = "abc123ABC@123456";
            int expected = 5;
            //assert
            Assert.AreEqual(expected, Passw.CheckPasw(password));
        }

        [TestMethod]
        public void CheckPasw_PasswordWithNoCriteria_0Returned()
        {
            //arrange
            string password = "123";
            int expected = 0;
            //assert
            Assert.AreEqual(expected, Passw.CheckPasw(password));
        }
    }
}
