namespace EstructuraDeDatosI
{
    /// <summary>
    /// Implementación de un "arreglo dinámico" desde cero sin listas ni arreglos de .NET.
    /// </summary>
    public class Arreglo<T>
    {
        private NodoArreglo<T> primero; // Primer nodo del "arreglo"
        private int capacidad; // Capacidad máxima del arreglo
        private int tamaño; // Número de elementos almacenados

        /// <summary>
        /// Constructor que inicializa el arreglo con una capacidad inicial.
        /// </summary>
        public Arreglo(int capacidadInicial)
        {
            capacidad = capacidadInicial;
            primero = null;
            tamaño = 0;
        }

        /// <summary>
        /// Agrega un elemento en la siguiente posición disponible.
        /// </summary>
        public void Agregar(T dato)
        {
            if (tamaño >= capacidad)
                throw new InvalidOperationException("El arreglo está lleno.");

            NodoArreglo<T> nuevoNodo = new NodoArreglo<T>(tamaño, dato); // Se usa tamaño como índice

            if (primero == null)
                primero = nuevoNodo;
            else
            {
                NodoArreglo<T> actual = primero;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevoNodo;
            }

            tamaño++;
        }

        /// <summary>
        /// Obtiene un elemento en una posición específica.
        /// </summary>
        public T Obtener(int indice)
        {
            if (indice < 0 || indice >= tamaño)
                throw new IndexOutOfRangeException("Índice fuera de rango.");

            NodoArreglo<T> actual = primero;
            while (actual != null)
            {
                if (actual.Indice == indice)
                    return actual.Dato;
                actual = actual.Siguiente;
            }

            throw new IndexOutOfRangeException("Elemento no encontrado.");
        }

        /// <summary>
        /// Devuelve la cantidad de elementos en el arreglo.
        /// </summary>
        public int Tamano()
        {
            return tamaño;
        }
    }

    /// <summary>
    /// Representa un nodo en el "arreglo dinámico".
    /// </summary>
    public class NodoArreglo<T>
    {
        public T Dato { get; set; }  // Almacena el valor en la celda
        public int Indice { get; private set; } // Índice dentro del arreglo
        public NodoArreglo<T> Siguiente { get; set; } // Enlace al siguiente nodo

        /// <summary>
        /// Constructor del nodo del arreglo.
        /// </summary>
        public NodoArreglo(int indice, T dato)
        {
            Indice = indice;
            Dato = dato;
            Siguiente = null;
        }
    }
}
