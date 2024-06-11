﻿using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class Gold
{
    public string GoldId { get; set; } = null!;

    public string? GoldName { get; set; }

    public long PurchasePrice { get; set; }

    public long SalePrice { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string? Kara { get; set; }

    public string? GoldPercent { get; set; }

    public float? WorldPrice { get; set; }

    public virtual User ModifiedByNavigation { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
