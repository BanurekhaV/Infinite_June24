using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Client.Models
{
    public class MVCProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int QuantityAvailable { get; set; }

    }
}