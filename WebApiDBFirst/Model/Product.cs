using System;
using System.Collections.Generic;

namespace WebApiDBFirst.Model;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal? Price { get; set; }

    public decimal? Discount { get; set; }

    public bool? Active { get; set; }

    public int? ModelId { get; set; }

    public int? StoreId { get; set; }

    public virtual Model? Model { get; set; }

    public virtual Store? Store { get; set; }
}
