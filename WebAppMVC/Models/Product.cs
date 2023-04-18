namespace WebAppMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public int Categorie { get; set; }
        public decimal? Prix { get; set; }
    }
}