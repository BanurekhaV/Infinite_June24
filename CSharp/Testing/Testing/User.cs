using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
   public class User
    {
        public Boolean IsAdmin { get; set; }
    }

    public class Reservation
    {
        public User BookedBy { get; set; }

        public bool CanBeCancelled(User user)
        {
            if (user.IsAdmin)
                return true;
            if (BookedBy == user)
                return true;
            return false;
        }
    }
}
