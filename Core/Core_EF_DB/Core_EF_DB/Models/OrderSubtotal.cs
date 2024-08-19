using System;
using System.Collections.Generic;

namespace Core_EF_DB.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
