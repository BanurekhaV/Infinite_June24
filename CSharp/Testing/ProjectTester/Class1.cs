using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Testing;

namespace ProjectTester
{
    [TestFixture]
    public class Class1
    {
        //arrange
        Program p = new Program();

        [Test]
        //1. test case
        public void Test_Login()
        {
            //Act
            string s1 = p.Login("Banurekha", "aaa");
            string s2 = p.Login("", "");
            string s3 = p.Login("Admin", "Admin@123");

            //Assert
            ClassicAssert.AreEqual("UserId or Password cannot be empty", s2);
            ClassicAssert.AreEqual("Incorrect User Id or Password", s1);
            ClassicAssert.AreEqual("Welcome Admin", s3);
        }
    }
}
