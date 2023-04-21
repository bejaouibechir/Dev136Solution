using System;
using System.Collections.Generic;

namespace WebApiDBFirst.Model;

public partial class Model
{
    public int Id { get; set; }

    public string Label { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
