using ListasCirculares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    internal class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;
        public Lista()
        {
            nodoInicial = new Nodo(siguiente: nodoInicial);
        }
        public bool ValidaVacio()
        {
            if (nodoInicial.Siguiente == nodoInicial)
            {
                return true;
            }
            return false;

        }
        public void VaciarLista()
        {
            nodoInicial.Siguiente = nodoInicial;
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
        public void Agregar(string valor)
        {
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != nodoInicial)
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nodoNuevo = new Nodo(valor, nodoInicial);
            nodoActual.Siguiente = nodoNuevo;
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

        public void AgregarNodoInicio(string valor)
        {
            Nodo nuevoNodo = new Nodo(valor, nodoInicial.Siguiente);
            nodoInicial.Siguiente = nuevoNodo;
        }

        public Nodo BuscarAnterior(string valor)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;

                while (nodoBusqueda.Siguiente != nodoInicial
                            && nodoBusqueda.Siguiente.Valor != valor)
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    if (nodoBusqueda.Siguiente.Valor == valor)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }

        public void BorrarNodo(string valor)
        {
            if (ValidaVacio() == false)
            {
                nodoActual = Buscar(valor);

                if (nodoActual != null)
                {
                    Nodo nodoAnterior = BuscarAnterior(valor);
                    if (!(nodoAnterior is null))
                    {
                        nodoAnterior.Siguiente = nodoActual.Siguiente;
                        nodoActual.Siguiente = null;
                    }
                }
            }
        }
    }
}
