public class NodoLista<T>
{
    public T Dato { get; set; } // Almacena el valor del nodo
    public NodoLista<T> Siguiente { get; set; } // Apunta al siguiente nodo en la lista

    public NodoLista(T dato)
    {
        this.Dato = dato;
        this.Siguiente = null; // Inicialmente, no apunta a nada
    }
}
