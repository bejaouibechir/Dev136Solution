using ConsoleMVC.Model;

namespace ConsoleMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerContext customer = new CustomerContext(); //Model
            Controller controller = new Controller();//Controlleur
            View  view = controller.Index(); //View 
            view.Display();


        }
    }


}
