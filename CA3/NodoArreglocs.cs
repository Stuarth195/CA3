namespace EstructuraDeDatos
{
    public class NodoArreglo<T>
    {
        public T Dato;
        public NodoArreglo<T> Siguiente;

        public NodoArreglo(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
