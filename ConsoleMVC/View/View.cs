using System;
using ConsoleMVC.Model;

namespace ConsoleMVC
{
    public class View
    {
        private readonly CustomerContext _model;

        public View(CustomerContext model) //Passe le model à partir du contrôleur
        {
            _model = model; 
        }

        public void Display()
        {
            var data = _model.getAll();
            foreach (var customer in data )
            {
                Console.WriteLine(customer);
            }
        }
    }
}