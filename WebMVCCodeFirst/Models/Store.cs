namespace WebMVCCodeFirst.Models
{
    public class Store
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string City  { get; set; }

        //Propriété de naviguation
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

        //Clé étrangère 
        public int? ResponsableId { get; set; }
        //Propriété de naviguation 
        public Responsible Responsible { get; set; }
    }
}
