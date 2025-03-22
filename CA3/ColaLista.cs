using System;
using EstructuraDeDatos;

namespace EstructuraDeDatos
{
    public class ColaLista<T> // Corregí el nombre
    {
        private Nodo<T> Frente;
        private Nodo<T> Final;
        private int Largo;

        public ColaLista()
        {
            Frente = null;
            Final = null;
            Largo = 0;
        }

        public bool IsEmpty()
        {
            return Largo == 0;
        }

        public void Encolar(T dato)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(dato);
            if (IsEmpty())
            {   
                Frente = nuevoNodo;
                Final = nuevoNodo;
            }
            else
            {
                Final.Siguiente = nuevoNodo;
                Final = nuevoNodo;
            }
            Largo++;
        }

        public void EnQueQue(T Item) // Este método no se comporta como una cola FIFO
        {
            Nodo<T> NuevoNodo = new Nodo<T>(Item);
            if (IsEmpty())
            {
                Frente = NuevoNodo;
                Final = NuevoNodo;
            }
            else
            {
                NuevoNodo.Siguiente = Frente;
                Frente = NuevoNodo;
            }
        }
    }
}
