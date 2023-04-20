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
            string datestr = "20/04/2023";
            DateTime date = datestr.ToDate();

        }
    }


    static public class StringExtension
    {
        static public DateTime ToDate(this String str)
        {
            DateTime result;
            string [] segements = str.Split('/');
            result = new DateTime(int.Parse(segements[2]), int.Parse(segements[1]), int.Parse(segements[0]));
            return result;
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