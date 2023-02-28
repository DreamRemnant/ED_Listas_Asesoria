using System;
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


            Console.WriteLine("Se agregan valores");
            lista.AgregarFinal("Uno");
            lista.AgregarFinal("Dos");
            lista.AgregarFinal("Tres");
            Console.WriteLine(lista.Recorrer());

            Console.WriteLine("Se borra Dos");
            lista.Borrar("Dos");
            Console.WriteLine(lista.Recorrer());

            Console.WriteLine("Se Agrega Cero al inicio");
            lista.AgregarInicio("Cero");
            Console.WriteLine(lista.Recorrer());

            Console.WriteLine("Vaciar lista");
            lista.VaciarLista();

            Console.WriteLine("Se agregan nuevos valores");
            lista.AgregarFinal("Cuatro");
            lista.AgregarFinal("Cinco");
            lista.AgregarFinal("Seis");
            Console.WriteLine(lista.Recorrer());


            Console.WriteLine("Valor anterior de Cinco");
            Console.WriteLine(  lista.BuscarAnterior("Cinco").Siguiente.Valor);

            Console.ReadKey();
        }
    }
}
