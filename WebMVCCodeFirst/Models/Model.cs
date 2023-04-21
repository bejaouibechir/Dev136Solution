namespace WebMVCCodeFirst.Models
{
    public class Model
    {
        public Model()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Label { get; set; }


        //Propriété de naviguation
        public virtual ICollection<Product> Products { get; set; } // = new List<Product>();
    }
}

