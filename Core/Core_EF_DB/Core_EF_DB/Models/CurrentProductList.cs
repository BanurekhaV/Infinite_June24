using System;
using System.Collections.Generic;

namespace Core_EF_DB.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
