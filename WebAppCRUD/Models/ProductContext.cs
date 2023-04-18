using System.Collections.Generic;
using System.Linq;

namespace WebAppCRUD.Models
{
    public class ProductContext
    {
       public List<Product> products;
       public List<Categroy> categroies;
        public ProductContext()
        {
            products = new List<Product>();
            categroies = new List<Categroy>();

           //categroies.Add(new Categroy { Id = 1, Label = "Voitures" });
            
            products.Add(new Product { Id = 1, Category = "Voitures", Label = "Mercdes", Price = 25000 });
            products.Add(new Product { Id = 2, Category = "Voiture", Label = "BMW", Price = 35000 });
            products.Add(new Product { Id = 3, Category = "Voitures", Label = "Opel", Price = 12000 });
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            return products.SingleOrDefault(p=>p.Id==id);
        }

        public void Update(int id, Product newproduct) {
            Product product = GetProduct(id);
            product = newproduct;
            
        }

        public void Delete(int id)
        {
            products.RemoveAt(id);
        }
    }
}