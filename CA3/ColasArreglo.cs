namespace EstructuraDeDatosI
{
    /// <summary>
    /// Implementación de una cola (FIFO) utilizando un "arreglo dinámico" personalizado.
    /// </summary>
    public class ColaArreglo<T>
    {
        private Arreglo<T> elementos; // Simula un arreglo dinámico
        private int frente;  // Índice del primer elemento en la cola
        private int final;   // Índice del último elemento en la cola
        private int capacidad; // Capacidad máxima de la cola
        private int tamaño; // Número de elementos en la cola

        /// <summary>
        /// Constructor que inicializa la cola con una capacidad dada.
        /// </summary>
        public ColaArreglo(int capacidadInicial)
        {
            capacidad = capacidadInicial;
            elementos = new Arreglo<T>(capacidadInicial); // Corrección aquí
            frente = 0;
            final = -1;
            tamaño = 0;
        }

        /// <summary>
        /// Verifica si la cola está vacía.
        /// </summary>
        public bool EstaVacia()
        {
            return tamaño == 0;
        }

        /// <summary>
        /// Verifica si la cola está llena.
        /// </summary>
        public bool EstaLlena()
        {
            return tamaño == capacidad;
        }

        /// <summary>
        /// Agrega un elemento al final de la cola.
        /// </summary>
        public void Encolar(T dato)
        {
            if (EstaLlena())
                throw new InvalidOperationException("La cola está llena.");

            final = (final + 1) % capacidad;
            elementos.Agregar(dato);
            tamaño++;
        }

        /// <summary>
        /// Elimina y devuelve el elemento en el frente de la cola.
        /// </summary>
        public T Desencolar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            T dato = elementos.Obtener(frente);
            frente = (frente + 1) % capacidad;
            tamaño--;
            return dato;
        }

        /// <summary>
        /// Devuelve el elemento en el frente de la cola sin eliminarlo.
        /// </summary>
        public T FrenteElemento()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            return elementos.Obtener(frente);
        }

        /// <summary>
        /// Devuelve la cantidad de elementos en la cola.
        /// </summary>
        public int Tamano()
        {
            return tamaño;
        }

        /// <summary>
        /// Muestra los elementos de la cola sin alterarla.
        /// </summary>
        public void MostrarCola()
        {
            if (EstaVacia())
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }

            Console.Write("Frente -> ");
            for (int i = 0; i < tamaño; i++)
            {
                int indice = (frente + i) % capacidad;
                Console.Write($"[{elementos.Obtener(indice)}] -> ");
            }
            Console.WriteLine(" Final");
        }
    }
}
