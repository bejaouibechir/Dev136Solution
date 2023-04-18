using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC
{
    public class Controller
    {
       Model.CustomerContext _model;
        public Controller()
        {
            _model = new Model.CustomerContext();
        }
        public View Index()
        {
            return new View(_model);
        }
    }
}
