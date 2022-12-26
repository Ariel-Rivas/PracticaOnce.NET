using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp2
{
    // declaracion de delegados
    public delegate void delegado(string message);

    class Program
    {
        static void Main(string[] args)
        {

            // instancia del delegate 
            delegado handler = DelegateMethod;

            //llamada del delegado
            handler("Soy el mismisimo message");

            //DelegateMethod("Hello world"); 

            MethodWithCallback(1, 2, handler); 

            MethodClass obj = new MethodClass();
            delegado d1 = obj.Method1;
            delegado d2 = obj.Method2;
            delegado d3 = DelegateMethod;

            //Both types of assigment are valid.

            delegado allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;

            allMethodsDelegate("Llamando a delegados");

            //Remove Method1.
            allMethodsDelegate -= d1;

            allMethodsDelegate("Llamando a delegados");

            //copy AllMethodsDelegate while removing d2;
            delegado oneMethodDelegate = allMethodsDelegate - d2;
        }
        public static void DelegateMethod(string menssage)
        {
            WriteLine(menssage);
            ReadLine();
        }

        public static void MethodWithCallback(int param1, int param2, delegado callback)
        {
            callback(" El numero es: " + (param1 + param2).ToString());
            ReadLine();
        }

    }
}


