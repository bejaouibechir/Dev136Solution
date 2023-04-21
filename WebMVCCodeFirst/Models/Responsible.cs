namespace WebMVCCodeFirst.Models
{
    public class Responsible
    {
        public Responsible()
        {
            Stores = new HashSet<Store>(); 
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public int Experience { get; set; }


        //Propiété de naviguation
        public virtual  ICollection<Store> Stores { get; set; }

    }
}
