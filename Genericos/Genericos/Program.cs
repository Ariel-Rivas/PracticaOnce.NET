using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace Genericos
{ 

    //declaro una clase generica 
    public class GenericList<T>
    {
        List<T> listado = new List<T>();  // Revisar

        public void Add(T input)
        {

        }

        public List<T> PintarValores()  // revisar
        {  
            return listado;
        }
    }  

    class TestGenericList
    {
        private class EjemploClase { }
        static void Main()
        {
            List<string> student_list = new List<string>();

            //Adding values to the list
            student_list.Add("Anna Bower");
            student_list.Add("Ian Mitchell");
            student_list.Add("Dorothy Newman");
            student_list.Add("Nathan Miller");
            student_list.Add("Andrew Dowd");
            student_list.Add("Gavin Davies");
            student_list.Add("Alexandra Berry");

          
            int student_count = student_list.Count; 

            //Printing the result
            WriteLine("Total Number of students: " + student_count.ToString()); 
            foreach(string item in student_list)
            {
                WriteLine(item);
            }
               WriteLine(student_list[0]);

            //declaro una lista de tipo entero
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(2023);
            list1.Add(3); 

        

            //declaro una lista de tipo string
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("Ariel");

            

            foreach(string item in list2.PintarValores())  // revisar
            {
                WriteLine(item);
            }
            ReadLine(); 
            //declaro una lista de tipo ejemplo clase
            GenericList<EjemploClase> list3 = new GenericList<EjemploClase>();
            list3.Add(new EjemploClase());

            Ejemplo<int>(7);
            Ejemplo<string>("Hello");
            Ejemplo<DateTime>(DateTime.Now);
           
           
            
            
            ReadLine();
        } 
        public static void Ejemplo<T>(T tipo)
        {
           WriteLine(tipo);
        }
    }
}
