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
   public class Class2
    {
        [Test]
        public void Cancellation_ByAdmin_ReturnsTrue()
        {
            //arrange
            var r = new Reservation();

            //act
            var result = r.CanBeCancelled(new User { IsAdmin = true });

            //assert
            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void Cancellation_By_BookedBy_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { BookedBy = user };
            var result = reservation.CanBeCancelled(user);
            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void Cancellation_DoneByOthers_ReturnsFalse()
        {
            var reservation = new Reservation { BookedBy = new User() };
            var result = reservation.CanBeCancelled(new User());

            ClassicAssert.IsFalse(result);
        }
    }
}
