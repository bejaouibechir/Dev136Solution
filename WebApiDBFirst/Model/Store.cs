using System;
using System.Collections.Generic;

namespace WebApiDBFirst.Model;

public partial class Store
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string City { get; set; } = null!;

    //Clé étrangère
    public int? ResponsibleId { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual Responsible? Responsible { get; set; }
}
