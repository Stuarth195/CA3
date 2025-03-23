namespace EstructuraDeDatosI
{
    public class ColaArreglo<T>
    {
        private Arreglo<T> elementos;
        private int frente;
        private int final;
        private int capacidad;
        private int tamaño;

        public ColaArreglo(int capacidadInicial)
        {
            capacidad = capacidadInicial;
            elementos = new Arreglo<T>(capacidadInicial);
            frente = 0;
            final = -1;
            tamaño = 0;
        }

        public bool EstaVacia()
        {
            return tamaño == 0;
        }

        public bool EstaLlena()
        {
            return tamaño == capacidad;
        }

        public void Encolar(T dato)
        {
            if (EstaLlena())
                throw new InvalidOperationException("La cola está llena.");

            final = (final + 1) % capacidad;

            if (final < tamaño)
                elementos.Actualizar(final, dato);
            else
                elementos.Agregar(dato);

            tamaño++;
        }

        public T Desencolar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            T dato = elementos.Obtener(frente);

            elementos.Actualizar(frente, default(T));

            frente = (frente + 1) % capacidad;
            tamaño--;
            return dato;
        }

        public T FrenteElemento()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            return elementos.Obtener(frente);
        }

        public int Tamano()
        {
            return tamaño;
        }

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
