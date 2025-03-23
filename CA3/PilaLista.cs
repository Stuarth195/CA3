using System;

namespace EstructuraDeDatosII
{
    // Implementacion de una pila (LIFO) utilizando una lista enlazada.
    public class PilaLista<T>
    {
        private NodoLista<T> Tope; // Nodo en la cima de la pila


        // Constructor que inicializa la pila vacía.
        public PilaLista()
        {
            Tope = null;
        }

        // Agrega un elemento a la pila.
        public void Push(T dato)
        {
            NodoLista<T> nuevoNodo = new NodoLista<T>(dato);
            nuevoNodo.Siguiente = Tope;
            Tope = nuevoNodo;
        }

        // Elimina y devuelve el elemento en la cima de la pila.
        public T Pop()
        {
            if (Tope == null)
                throw new InvalidOperationException("La pila esta vacia.");

            T dato = Tope.Dato;
            Tope = Tope.Siguiente;
            return dato;
        }

        // Devuelve el elemento en la cima de la pila sin eliminarlo.
        public T Top()
        {
            if (Tope == null)
                throw new InvalidOperationException("La pila esta vacia.");

            return Tope.Dato;
        }
    }

    // Clase que representa un nodo en la pila enlazada.
    public class NodoLista<T>
    {
        public T Dato;
        public NodoLista<T> Siguiente;

        public NodoLista(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
