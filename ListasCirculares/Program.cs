﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            //Console.WriteLine(lista.RecorrerLista());

            lista.Agregar("Uno");
            lista.Agregar("Dos");
            lista.Agregar("Tres");
            //Console.WriteLine(lista.RecorrerLista());


            lista.AgregarNodoInicio("Cero");
            Console.WriteLine(lista.Recorrer());


            Nodo NodoBusqueda = lista.Buscar("Uno");
            if (NodoBusqueda != null)
            {
                Console.WriteLine(NodoBusqueda.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Nodo NodoBusquedaAnterior = lista.BuscarAnterior("Dos");
            if (NodoBusquedaAnterior != null)
            {
                Console.WriteLine(NodoBusquedaAnterior.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Console.WriteLine("");
            Console.WriteLine("Eliminando el uno");
            lista.BorrarNodo("Uno");
            Console.WriteLine(lista.Recorrer());

            Console.ReadKey();
        }
    }
}
