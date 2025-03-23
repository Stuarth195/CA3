using System;
using EstructuraDeDatosI;

class Program
{
    static void Main()
    {
        // Crear un arreglo de colas con capacidad para 3 colas
        Arreglo<ColaArreglo<string>> arregloDeColas = new Arreglo<ColaArreglo<string>>(3);

        // Agregar colas al arreglo
        for (int i = 0; i < 3; i++)
        {
            ColaArreglo<string> nuevaCola = new ColaArreglo<string>(3); // Cada cola puede tener 3 elementos
            arregloDeColas.Agregar(nuevaCola);
        }

        // Encolar elementos en cada cola
        arregloDeColas.Obtener(0).Encolar("A1");
        arregloDeColas.Obtener(0).Encolar("A2");
        arregloDeColas.Obtener(0).Encolar("A3");

        arregloDeColas.Obtener(1).Encolar("B1");
        arregloDeColas.Obtener(1).Encolar("B2");
        arregloDeColas.Obtener(1).Encolar("B3");

        arregloDeColas.Obtener(2).Encolar("C1");
        arregloDeColas.Obtener(2).Encolar("C2");
        arregloDeColas.Obtener(2).Encolar("C3");

        // Mostrar todo el contenido del arreglo de colas
        Console.WriteLine("Contenido del arreglo de colas:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Cola {i + 1}: ");
            arregloDeColas.Obtener(i).MostrarCola();
        }

        Console.WriteLine();

        // Obtener y mostrar una cola específica
        int indice = 1; // Cambia este número para probar con otra lista (0, 1 o 2)
        Console.WriteLine($"Mostrando la cola en la posición {indice}:");
        ColaArreglo<string> colaObtenida = arregloDeColas.Obtener(indice);
        colaObtenida.MostrarCola();
    }
}
