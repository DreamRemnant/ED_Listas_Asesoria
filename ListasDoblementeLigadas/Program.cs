using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            //Console.WriteLine(lista.RecorrerLista());

            lista.AgregarFinal("Uno");
            lista.AgregarFinal("Dos");
            lista.AgregarFinal("Tres");
            //Console.WriteLine(lista.RecorrerLista());


            lista.AgregarInicio("Cero");
            Console.WriteLine(lista.Recorrer());

            Nodo NodoBusqueda = lista.Buscar("Uno");
            if (NodoBusqueda != null)
            {
                Console.WriteLine(NodoBusqueda.Valor + ", con Nodo anterior: [" + NodoBusqueda.Anterior.Valor + "] y Nodo siguiente: [" + NodoBusqueda.Siguiente.Valor + "]");
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }
            

            Console.WriteLine("");
            Console.WriteLine("Eliminando el uno");
            lista.EliminarNodo("Uno");
            Console.WriteLine(lista.Recorrer());

            lista.AgregarInicio("Cuatro");

            NodoBusqueda = lista.Buscar("Dos");
            if (NodoBusqueda != null)
            {
                Console.WriteLine(NodoBusqueda.Valor + ", con Nodo anterior: [" + NodoBusqueda.Anterior.Valor + "] y Nodo siguiente: [" + NodoBusqueda.Siguiente.Valor + "]");
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Console.ReadKey();
        }
    }
}
