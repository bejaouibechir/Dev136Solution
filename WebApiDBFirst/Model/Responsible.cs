using System;
using System.Collections.Generic;

namespace WebApiDBFirst.Model;

public partial class Responsible
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Experience { get; set; }

    public bool? Gender { get; set; }

    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
