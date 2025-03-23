namespace EstructuraDeDatosI
{
    public class Arreglo<T>
    {
        private NodoArreglo<T> primero;
        private int capacidad;
        private int tamaño;

        public Arreglo(int capacidadInicial)
        {
            capacidad = capacidadInicial;
            primero = null;
            tamaño = 0;
        }

        public void Agregar(T dato)
        {
            if (tamaño >= capacidad)
                throw new InvalidOperationException("El arreglo está lleno.");

            NodoArreglo<T> nuevoNodo = new NodoArreglo<T>(tamaño, dato);

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

        public T Obtener(int indice)
        {
            if (indice < 0 || indice >= tamaño)
                throw new IndexOutOfRangeException("Índice fuera de rango.");

            NodoArreglo<T> actual = primero;
            for (int i = 0; i < indice; i++)
                actual = actual.Siguiente;

            return actual.Dato;
        }

        public void Actualizar(int indice, T dato)
        {
            if (indice < 0 || indice >= tamaño)
                throw new IndexOutOfRangeException("Índice fuera de rango.");

            NodoArreglo<T> actual = primero;
            for (int i = 0; i < indice; i++)
                actual = actual.Siguiente;

            actual.Dato = dato;
        }

        public int Tamano()
        {
            return tamaño;
        }
    }

    public class NodoArreglo<T>
    {
        public T Dato { get; set; }
        public int Indice { get; private set; }
        public NodoArreglo<T> Siguiente { get; set; }

        public NodoArreglo(int indice, T dato)
        {
            Indice = indice;
            Dato = dato;
            Siguiente = null;
        }
    }
}
