using MyZone.Utils;
using NUnit.Framework;
using System;
using MyZone;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Passwords passwords = new Passwords();
            string RealPassword = "skdjkkfkf";
            string HashedPassword = passwords.EncryptPassword(RealPassword);
            Console.Write(HashedPassword);
            Assert.IsNotEmpty(HashedPassword);
        }
    }
}