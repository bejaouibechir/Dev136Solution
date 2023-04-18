using System.Collections.Generic;

namespace ConsoleMVC.Model
{
    public class CustomerContext  //La classe CRUD 
    {
        List<Customer> _customers;
        
        public CustomerContext()
        {
           _customers = new List<Customer>();
           _customers.Add(new Customer { Id=1,Name="Bechir", Contact="contact"});
            _customers.Add(new Customer { Id = 2, Name = "Bechir2", Contact = "contact" });
            _customers.Add(new Customer { Id = 3, Name = "Bechir3", Contact = "contact" });
        }

        public void Add(Customer customer) { 
          _customers.Add(customer);
        }
        public void Update(int id, Customer customer)
        {
            Customer current = _customers[id];
            if (current != null)
            {
                current = customer;
            }
        }
        public Customer Get(int id)
        { 
            return _customers[id];
        }

        public void Delete(int id) { 
          Customer customer = _customers[id];
            if(customer != null)
            {
                _customers.RemoveAt(id);
            }
        }
        public List<Customer> getAll() { 
         return _customers;
        }
    }
}
