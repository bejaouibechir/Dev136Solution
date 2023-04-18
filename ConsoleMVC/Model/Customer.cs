using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Model
{
    public class Customer //Une entité ou classe POCO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} Nom:{Name} Contact: {Contact}";
        }
    }
}
