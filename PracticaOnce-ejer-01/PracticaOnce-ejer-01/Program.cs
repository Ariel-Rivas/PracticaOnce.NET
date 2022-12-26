using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 
namespace PracticaOnce_ejer_01
{
    //Crea un programa que use un diccionario, clave entera y valor string. 
    //Se pedirá por consola, un numero y una cadena, que se ira insertando 
    //en el diccionario, hasta que se introduzca el valor "0". una vez se pulse "0",
    //se pedirá por pantalla que se introduzca una cadena.  
    //se mostrara consultando el diccionario, todas las claves que contienen ese valor 


    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            int Num = -1;


            while ( Num != 0)
            {
                WriteLine("Ingrese un numero ");
                int numero = int.Parse(ReadLine());

                WriteLine("Ingrese una cadena ");
                string cadena = (ReadLine());

                diccionario.Add(numero,cadena);

                Num = numero; 
            }
               WriteLine("Introduce un valor");
                var cadena2 = ReadLine();

            if (diccionario.ContainsValue(cadena2))
            {
                var coincide = diccionario.Where(x => x.Value.Contains(cadena2));

                foreach(var item in coincide)
                {
                    WriteLine("Coincidencia: " + item.Value);
                }
            }

              ReadLine(); 
        }
    }
}
