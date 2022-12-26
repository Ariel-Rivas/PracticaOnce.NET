using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Numeracion
{
    class Program
    {

        static void PrintColor(Color color)
        {
            switch (color)
            {
                case Color.Rojo:
                    WriteLine("Rojo");
                    break;
                case Color.Verde:
                    WriteLine("Verde");
                    break;
                case Color.Azul:
                    WriteLine("Azul");
                    break;
                default:
                    WriteLine(" color  desconocido");
                    break;
            }
        }
        static void Main(string[] args)
        {

            Color c = Color.Rojo;
            PrintColor(c);
            PrintColor(Color.Azul);

            int i = (int)Color.Azul;
            Color c2 = (Color)2;

            var alineacion = Alignment.left;
            ReadLine();
        }
        
    }
}