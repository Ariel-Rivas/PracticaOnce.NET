using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tupla
{
    class Program
    {
        static void Main(string[] args)
        {

            var tupla = new Tuple< int, string, string, DateTime>(1, "Lionel ", "Francisco", DateTime.Now);

            var tupla2 = Tuple.Create(1, "Damian", "Daniel ", DateTime.Now);

            var ejemplo = Ejemplo(); 

            //acceder a los valores de la tupla
            var entero = ejemplo.Item1;
            var nombre1 = ejemplo.Item2;
            var nombre2 = ejemplo.Item3;
          

            WriteLine(entero);
            WriteLine(nombre1);
            WriteLine(nombre2);
            WriteLine(tupla);
            WriteLine(tupla2);
            ReadLine();
        }

        public static Tuple<int, string,string, DateTime>Ejemplo()
        {
            return new Tuple<int, string,  string, DateTime>(1, "Lionel" , "Francisco", DateTime.Now);
        
        }
       
    }
    
}
