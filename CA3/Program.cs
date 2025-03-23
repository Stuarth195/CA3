using System;
using EstructuraDeDatos;

class Program
{
    static void Main()
    {
        // Crear una cola de enteros
        ColaLista<int> cola = new ColaLista<int>();

        // Encolar elementos en la cola
        cola.Encolar(10);
        cola.Encolar(20);
        cola.Encolar(30);

        // Mostrar el estado actual de la cola
        cola.MostrarCola(); // Salida esperada: Frente → [10] → [20] → [30] →  Final

        // Desencolar un elemento
        Console.WriteLine($"Desencolado: {cola.Desencolar()}"); // 10
        cola.MostrarCola(); // Frente → [20] → [30] →  Final

        // Ver el frente de la cola sin eliminarlo
        Console.WriteLine($"Frente: {cola.FrenteElemento()}"); // 20

        // Obtener el tamaño de la cola
        Console.WriteLine($"Tamaño: {cola.Tamano()}"); // 2
    }
}
