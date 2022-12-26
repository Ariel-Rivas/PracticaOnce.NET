using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PracticaOnce_ejer_02

//Crear un programa que tenga una clase que acepte un tipo genérico. 
//esa clase tendrá un método que ira añadiendo a un Listado de ese tipo, 
//todos los valores introducidos por consola.
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassGeneric<int> listado = new ClassGeneric<int>();


            listado.Añadir(25);
            listado.Añadir(32);
            listado.Añadir(45);
            listado.Añadir(99);

            foreach (int item in listado.PintarValores())
            {
                WriteLine(item);

            }
            ReadLine();



            ClassGeneric<string> listado2 = new ClassGeneric<string>();

            listado2.Añadir("Tokio 22");
            listado2.Añadir("Buenos Aires");
            listado2.Añadir("Numero 44");

            foreach (var item in listado2.PintarValores())
            {
                WriteLine(item);

            }

            ReadLine();

        }
    }
}

