using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTests
{
    [TestClass]
    public class UnitTest_For_Helper
    {
        [TestMethod]
        public void HashPassword_ShouldReturnHash()
        {
            string result = PasswordHelper.HashPassword("674256");
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void HashPassword_ShouldBe64Chars()
        {
            string result = PasswordHelper.HashPassword("8956674");
            Assert.AreEqual(64, result.Length);
        }
        [TestMethod]
        public void HashPassword_SamePassword_SameHash()
        {
            string hash1 = PasswordHelper.HashPassword("907856");
            string hash2 = PasswordHelper.HashPassword("907856");
            Assert.AreEqual(hash1, hash2);
        }
    }
}
