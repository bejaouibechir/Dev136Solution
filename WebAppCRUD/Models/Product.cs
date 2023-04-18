namespace WebAppCRUD.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Category { get; set; }
        public decimal? Price { get; set; }
    }
}