namespace EstructuraDeDatos
{
    /// <summary>
    /// Implementación de una cola (FIFO) utilizando una lista enlazada.
    /// La cola sigue el principio "First In, First Out" (el primero en entrar es el primero en salir).
    /// </summary>
    public class ColaLista<T>
    {
        private NodoLista<T> Frente; // Nodo que representa el frente de la cola (primer elemento)
        private NodoLista<T> Final;  // Nodo que representa el final de la cola (último elemento)
        private int Largo;      // Número de elementos en la cola

        /// <summary>
        /// Constructor de la cola. Inicializa la estructura vacía.
        /// </summary>
        public ColaLista()
        {
            Frente = null;
            Final = null;
            Largo = 0;
        }

        /// <summary>
        /// Verifica si la cola está vacía.
        /// </summary>
        /// <returns>True si la cola está vacía, False en caso contrario.</returns>
        public bool IsEmpty()
        {
            return Largo == 0;
        }

        /// <summary>
        /// Inserta un elemento al final de la cola.
        /// </summary>
        /// <param name="dato">El dato a insertar.</param>
        public void Encolar(T dato)
        {
            NodoLista<T> nuevoNodo = new NodoLista<T>(dato);
            if (IsEmpty()) // Si la cola está vacía, el nuevo nodo será el primero y el último
            {
                Frente = nuevoNodo;
                Final = nuevoNodo;
            }
            else
            {
                Final.Siguiente = nuevoNodo; // Conectar el último nodo con el nuevo
                Final = nuevoNodo;           // Actualizar el puntero Final
            }
            Largo++; // Incrementar la cantidad de elementos
        }

        /// <summary>
        /// Elimina y devuelve el elemento del frente de la cola.
        /// </summary>
        /// <returns>El elemento eliminado.</returns>
        /// <exception cref="InvalidOperationException">Se lanza si la cola está vacía.</exception>
        public T Desencolar()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La cola está vacía, no se puede desencolar.");

            T dato = Frente.Dato; // Obtener el dato del nodo en el frente
            Frente = Frente.Siguiente; // Mover el frente al siguiente nodo

            if (Frente == null) // Si la cola queda vacía, también se actualiza Final
                Final = null;

            Largo--; // Reducir la cantidad de elementos
            return dato; // Retornar el dato eliminado
        }

        /// <summary>
        /// Devuelve el elemento en el frente de la cola sin eliminarlo.
        /// </summary>
        /// <returns>El elemento en el frente.</returns>
        /// <exception cref="InvalidOperationException">Se lanza si la cola está vacía.</exception>
        public T FrenteElemento()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La cola está vacía, no hay elementos.");

            return Frente.Dato;
        }

        /// <summary>
        /// Devuelve la cantidad de elementos en la cola.
        /// </summary>
        /// <returns>El número de elementos en la cola.</returns>
        public int Tamano()
        {
            return Largo;
        }

        /// <summary>
        /// Muestra los elementos de la cola sin alterarla.
        /// </summary>
        public void MostrarCola()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }

            NodoLista<T> actual = Frente;
            Console.Write("Frente -> ");
            while (actual != null)
            {
                Console.Write($"[{actual.Dato}] -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine(" <- Final");
        }
    }

    /// <summary>
    /// Clase que representa un nodo en la cola enlazada.
    /// </summary>
    public class NodoLista<T>
    {
        public T Dato;         // Valor almacenado en el nodo
        public NodoLista<T> Siguiente; // Puntero al siguiente nodo en la cola

        /// <summary>
        /// Constructor del nodo.
        /// </summary>
        /// <param name="dato">El valor del nodo.</param>
        public NodoLista(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
