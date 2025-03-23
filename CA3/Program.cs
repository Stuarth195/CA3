using System;
using EstructuraDeDatos;
using EstructuraDeDatosI;
class Program
{
    static void Main()
    {
        // Prueba de ColaLista
        Console.WriteLine("=== Prueba ColaLista ===");
        ColaLista<int> colaLista = new ColaLista<int>();

        colaLista.Encolar(10);
        colaLista.Encolar(20);
        colaLista.Encolar(30);

        colaLista.MostrarCola(); // Frente -> [10] -> [20] -> [30] -> Final

        Console.WriteLine($"Desencolado: {colaLista.Desencolar()}"); // 10
        colaLista.MostrarCola(); // Frente -> [20] -> [30] -> Final

        Console.WriteLine($"Frente: {colaLista.FrenteElemento()}"); // 20
        Console.WriteLine($"Tamaño: {colaLista.Tamano()}"); // 2

        // Prueba de ColaArreglo
        Console.WriteLine("\n=== Prueba ColaArreglo ===");
        ColaArreglo<int> colaArreglo = new ColaArreglo<int>(5); // Capacidad de 5

        colaArreglo.Encolar(10);
        colaArreglo.Encolar(20);
        colaArreglo.Encolar(30);

        colaArreglo.MostrarCola(); // Frente -> [10] -> [20] -> [30] -> Final

        Console.WriteLine($"Desencolado: {colaArreglo.Desencolar()}"); // 10
        colaArreglo.MostrarCola(); // Frente -> [20] -> [30] -> Final

        Console.WriteLine($"Frente: {colaArreglo.FrenteElemento()}"); // 20
        Console.WriteLine($"Tamaño: {colaArreglo.Tamano()}"); // 2
    }
}
