using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing;
using System.Diagnostics;


namespace Project_MsTester
{
    [TestClass]
    public class Class1
    {
        Program p = new Program();
        [TestMethod]
        public void Cancellation_ByAdmin_ReturnsTrue()
        {
            var reservation = new Reservation();
            var result = reservation.CanBeCancelled(new User { IsAdmin = true });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Cancellation_ByUser_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { BookedBy = user };
            var result = reservation.CanBeCancelled(user);
            Assert.IsTrue(result);
        }
        [TestInitialize]
        public void BeforeRunningTest()
        {
            Debug.WriteLine(" Test Initialize");
        }

        [TestCleanup]
        public void AfterAllTest()
        {
            Debug.WriteLine(" Test Cleanup..");
        }

        [ClassInitialize]
        public static void Class_initialize(TestContext tc)
        {
            tc.WriteLine(" Test Class Initialize");
        }

        [ClassCleanup]
        public static void Class_cleanUp()
        {
            Debug.WriteLine("Test class CleanUp.");
        }

        
    }
}
