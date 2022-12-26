using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PracticaOnce_ejer_03
{

    // 3- Crear un enumerado llamado "animales" con los siguientes valores, perro = 5, gato = 8, canario = 2, caballo = 12.
    //Se creara una clase Animal, con una propiedad que sea el tipo de animal.
    //Se pedirá por consola, un numero, si coincide con el valor del animal se 
    //pintara en pantalla "ese valor pertenece al <nombre animal>" realizar el ejercicio con todos 
    //los elementos vistos hasta la fecha (clases, funciones, enumerados, diccionarios, tuplas o lo 
    //que veamos conveniente para su resolución).
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Ingrese un numero");
            var num = int.Parse(ReadLine());

            WriteLine($"El valor ingresado pertenece al {tipo(num)}");
            ReadLine();
        }
            public static string tipo(int TipoDeAnimal)
        {
            switch (TipoDeAnimal)
            {
                case 12: return Animales.Caballo.ToString();
                    break;
                case 2: return Animales.Canario.ToString();
                    break;
                case 8: return Animales.Gato.ToString();
                    break;
                case 5: return Animales.Perro.ToString();
                    break;
                default:
                    return "valor desconocido";
                    break;
            }
            return string.Empty; 
        }
    }
}
