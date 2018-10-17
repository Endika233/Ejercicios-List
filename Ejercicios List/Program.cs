using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaTipo = new List<string>();
            CrearLista(listaTipo);
            Console.WriteLine("La lista tiene " + ContarElementos(listaTipo) + " elementos");
            MostrarLista(listaTipo);
            OrdenarLista(listaTipo);
            MostrarLista(listaTipo);
            BorrarDeLaLista(listaTipo, "Pan");
            MostrarLista(listaTipo);
            Console.WriteLine("La lista tiene " + ContarElementos(listaTipo) + " elementos");
            Console.ReadLine();
        }
        public static void CrearLista(List<string> listaTipo)
        {
            listaTipo.Add("Pan");
            listaTipo.Add("Hamburguesas");
            listaTipo.Add("Cerveza");
        }
        public static void MostrarLista(List<string> listaTipo)
        {
            for (int i = 0; i < listaTipo.Count; i++)
            {
                Console.WriteLine(listaTipo.ElementAt(i));               
            }
        }
        public static void OrdenarLista(List<string> listaTipo)
        {
            listaTipo.Sort();////Este método ordena directamente
        }
        public static void BorrarDeLaLista(List<string> listaTipo,string datoBorrar)
        {
            listaTipo.Remove(datoBorrar);
        }
        public static int ContarElementos(List<string> listaTipo)
        {
            return listaTipo.Count();
        }
    }
}
//Hay que crear 5 funciones:
//Método CreaLista:
//Esta función recibirá por parámetro la lista que crearemos en el programa y la devolverá escrita.
//Método MostrarLista:
//Esta función simplemente recibirá la lista por parámetro y la mostrará en pantalla.
//Crea un método OrdenarLista:
//Ordena alfabéticamente la lista que reciba por parámetro.
//Crea un método BorrarDeLaLista:
//Recibirá un elemento y una lista por parámetro. Si encuentra el elemento en la lista lo borrara.
//Crea un método ContarElementos:
//Recibe una lista por parámetro y devuelve la cantidad de elementos en ella.
