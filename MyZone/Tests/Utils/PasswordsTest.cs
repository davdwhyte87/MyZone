using System;
using NUnit.Framework;
using MyZone.Utils;

namespace MyZone.Tests.Utils
{
    [TestFixture]
    public class PasswordsTest
    {
        [Test]
        public void Should_Generate_PasswordHash()
        {
            Passwords passwords = new Passwords();
            string RealPassword = "skdjkkfkf";
            string HashedPassword = passwords.EncryptPassword(RealPassword);
            Assert.IsNotEmpty(HashedPassword);
        }
    }
}
