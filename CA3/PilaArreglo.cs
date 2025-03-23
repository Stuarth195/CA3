using System;

namespace EstructuraDeDatosIII
{
    public class PilaArreglo<T>
    {
        private NodoArreglo<T>[] elementos; // Arreglo de nodos
        private int capacidad; // Capacidad maxima de la pila
        private int tamaño; // Numero actual de elementos en la pila

        // Constructor de la pila con capacidad definida.
        public PilaArreglo(int capacidadInicial)
        {
            capacidad = capacidadInicial;
            elementos = new NodoArreglo<T>[capacidad];
            tamaño = 0;
        }

        // Agrega un elemento a la pila.
        public void Push(T dato)
        {
            if (tamaño >= capacidad)
                throw new InvalidOperationException("La pila está llena.");

            elementos[tamaño] = new NodoArreglo<T>(tamaño, dato);
            tamaño++;
        }

        // Elimina y devuelve el elemento en la cima de la pila.
        public T Pop()
        {
            if (tamaño == 0)
                throw new InvalidOperationException("La pila está vacía.");

            tamaño--;
            return elementos[tamaño].Dato;
        }

        // Devuelve el elemento en la cima de la pila sin eliminarlo.
        public T Top()
        {
            if (tamaño == 0)
                throw new InvalidOperationException("La pila está vacía.");

            return elementos[tamaño - 1].Dato;
        }
    }


    // Clase que representa un nodo en la pila con arreglo.
    public class NodoArreglo<T>
    {
        public T Dato { get; set; }
        public int Indice { get; private set; }

        public NodoArreglo(int indice, T dato)
        {
            Indice = indice;
            Dato = dato;
        }
    }
}

// Algo paso y no me deja arregar la dependencia del proyecto CA3, creo que es algo del git