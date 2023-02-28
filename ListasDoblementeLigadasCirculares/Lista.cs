using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares
{
    internal class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;
        public Lista()
        {
            nodoInicial = new Nodo();
            nodoInicial.Siguiente = nodoInicial;
            nodoInicial.Anterior = nodoInicial;
        }
        public bool ValidaVacio()
        {
            if (nodoInicial.Siguiente == nodoInicial)
            {
                return true;
            }
            return false;
            //return nodoInicial.Siguiente == null;

        }
        public void VaciarLista()
        {
            nodoInicial.Siguiente = nodoInicial;
            nodoInicial.Anterior = nodoInicial;
        }
        public string Recorrer()
        {
            string datos = string.Empty;
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != nodoInicial)
            {
                nodoActual = nodoActual.Siguiente;
                datos += nodoActual.Valor + "\n";
            }
            return datos;
        }
        public void AgregarFinal(string valor)
        {
            
            if (nodoInicial.Siguiente == nodoInicial)
            {
                Nodo nodoNuevo = new Nodo(valor, nodoInicial, nodoInicial);
                nodoInicial.Siguiente = nodoNuevo;
                nodoInicial.Anterior = nodoNuevo;
            }
            else
            {
                nodoActual = nodoInicial;
                while (nodoActual.Siguiente != nodoInicial)
                {
                    nodoActual = nodoActual.Siguiente;
                }
                Nodo nodoNuevo = new Nodo(valor, nodoActual, nodoInicial);
                nodoActual.Siguiente = nodoNuevo;
                nodoInicial.Anterior = nodoNuevo;
            }
            
        }

        public void AgregarInicio(string valor)
        {
            if (ValidaVacio())
            {
                AgregarFinal(valor);
                return;
            }
            Nodo nodoNuevo = new Nodo(valor,nodoInicial,nodoInicial.Siguiente);
            nodoInicial.Siguiente.Anterior = nodoNuevo;
            nodoInicial.Siguiente = nodoNuevo;
        }
        public Nodo Buscar(string valor)
        {
            if (ValidaVacio())
            {
                return null;
            }

            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != nodoInicial)
            {
                nodoActual = nodoActual.Siguiente;
                if (nodoActual.Valor == valor)
                {
                    return nodoActual;
                }
            }
            return null;
        }

        public void Borrar(string valor)
        {
            nodoActual = Buscar(valor);
            if (nodoActual != null)
            {
                nodoActual.Anterior.Siguiente = nodoActual.Siguiente;
                nodoActual.Siguiente.Anterior = nodoActual.Anterior;
                nodoActual.Siguiente = null;
                nodoActual.Anterior = null;
            }
        }
    }
}
