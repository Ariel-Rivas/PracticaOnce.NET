using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOnce_ejer_02
{
    public class ClassGeneric<T>
    {
        List<T> ListaGenerica = new List<T>();

        public void Añadir(T valor)
        {
            ListaGenerica.Add(valor);
        }
        public List<T> PintarValores()
        {
            return ListaGenerica;
        } 
          
    }
}
