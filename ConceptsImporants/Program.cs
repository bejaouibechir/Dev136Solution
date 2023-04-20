using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsImporants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 45;
            double b = 10;
            Operation((x, y) => x - y, a, b);
            Console.ReadLine();
        }
        static void Operation(Func<double,double,double> func,double a,double b)
        {
            double resultat = func.Invoke(a, b);
            Console.WriteLine(resultat);
        }
    }


   

}






//        Func<double, double, double> delegatesomme;
//        string input;
//        Console.WriteLine("Si vous voulez faire une somme tapez 1 ");
//            Console.WriteLine("Si vous voulez faire une soustraction tapez 2 ");
//            input = Console.ReadLine();
//            if(input == "1")
//            {
//                delegatesomme = somme;
//                affiche(somme, 11, 44);
//    }
//            else
//            {
//                delegatesomme = soustraction;
//                affiche(soustraction,66, 11);
//}
//Console.Read();


//static double soustraction(double x, double y) { return x - y; }
//        static double somme(double x,double y) { return x + y; }


//        static double sommelambda(double x,double y) => x + y; //Bodied expression 

/*  Ancienne forme de passage de methode en tant que argument 
 *  
 *  
 *   delegate double delegatesomme(double x, double y);
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Si vous voulez faire une somme tapez 1 ");
            Console.WriteLine("Si vous voulez faire une soustraction tapez 2 ");
            input = Console.ReadLine();
            if(input == "1")
            {
                affiche(somme, 11, 44);
            }
            else
            {
                affiche(soustraction,66, 11);
            }
            Console.Read()
        }

        static void affiche(delegatesomme operation,double x,double y)
        {
            
            double resulat = operation.Invoke(x,y); 
            Console.WriteLine(resulat);

        }

        static double soustraction(double x, double y) { return x - y; }
        static double somme(double x,double y) { return x + y; }
        
        
        static double sommelambda(double x,double y) => x + y; //Bodied expression 
 
 */