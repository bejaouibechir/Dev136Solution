namespace WebMVCCodeFirst.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }

        //Clé étrangère de model

        public int? ModelId { get; set; }

        //Propriété de naviguation 
        public Model Model { get; set; }

        //Clé étrangère de store

        public int? StoreId { get; set; }

        //Propriété de naviguation 

        public Store Store { get; set; }

    }

}
