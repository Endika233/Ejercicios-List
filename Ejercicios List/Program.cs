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
            //Primer Ejercicio
            //List<string> listaTipo = new List<string>();
            //CrearLista(listaTipo);
            //Console.WriteLine("La lista tiene " + ContarElementos(listaTipo) + " elementos");
            //MostrarLista(listaTipo);
            //OrdenarLista(listaTipo);
            //MostrarLista(listaTipo);
            //BorrarDeLaLista(listaTipo, "Pan");
            //MostrarLista(listaTipo);
            //Console.WriteLine("La lista tiene " + ContarElementos(listaTipo) + " elementos");
            //Console.ReadLine();

            //Segundo Ejercicio
            //Lee por consola los números que introduzca el usuario.
            //Si el número introducido es decimal lo guardará en una lista de números decimales,.
            //Si no es decimal entonces los guardará en una lista de ints.
            //Una vez haya introducido un número negativo:
            //Muestra cuántos números decimales y cuantos enteros ha creado.
            //Haz la suma de todos los números enteros introducidos.
            //Saca la media de todos los números, tanto enteros como decimales.
            //Controla las posibles excepciones que se puedan dar, como por ejemplo introducir un número negativo.

            List<int> listaEnteros = new List<int>();
            List<double> listaDecimales = new List<double>();
            string respuesta;
            double sumaDecimales = 0,mediaTotal;
            int sumaEnteros=0;
            do
            {
                Console.WriteLine("Escriba un número");
                respuesta = Console.ReadLine();
                if (respuesta.Contains(",") || respuesta.Contains("."))
                {
                    try
                    {
                        listaDecimales.Add(Convert.ToDouble(respuesta));
                    }
                    catch { Console.WriteLine("El tipo de dato introducido no es correcto"); }
                }
                else
                {
                    try
                    {
                        listaEnteros.Add(Convert.ToInt32(respuesta));
                    }
                    catch { Console.WriteLine("El tipo de dato introducido no es correcto"); }
                }

            } while (!respuesta.Contains("-"));
            Console.WriteLine("La lista de números decimales contiene " + listaDecimales.Count() + " números y la lista de números enteros " + listaEnteros.Count());
            foreach (int x in listaEnteros)
            {
                sumaEnteros=sumaEnteros+x;
            }
            Console.WriteLine("La suma de todos los enteros es " + sumaEnteros);
            foreach (double x in listaDecimales)
            {
                sumaDecimales = sumaDecimales + x;
            }
            mediaTotal = (Convert.ToDouble(sumaEnteros) + sumaDecimales) / Convert.ToDouble(listaEnteros.Count() + listaDecimales.Count());
            Console.WriteLine("La media global es "+mediaTotal);
            Console.ReadKey();
        }

        //public static void CrearLista(List<string> listaTipo)
        //{
        //    listaTipo.Add("Pan");
        //    listaTipo.Add("Hamburguesas");
        //    listaTipo.Add("Cerveza");
        //}
        //public static void MostrarLista(List<string> listaTipo)
        //{
        //    for (int i = 0; i < listaTipo.Count; i++)
        //    {
        //        Console.WriteLine(listaTipo.ElementAt(i));               
        //    }
        //}
        //public static void OrdenarLista(List<string> listaTipo)
        //{
        //    listaTipo.Sort();////Este método ordena directamente
        //}
        //public static void BorrarDeLaLista(List<string> listaTipo,string datoBorrar)
        //{
        //    listaTipo.Remove(datoBorrar);
        //}
        //public static int ContarElementos(List<string> listaTipo)
        //{
        //    return listaTipo.Count();
        //}
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
    }
}
