using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            // Mostrar el menú de opciones
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Sumar números pares hasta 75.");
            Console.WriteLine("2. Encontrar el número más grande en una lista.");
            Console.WriteLine("3. Generar una tabla de multiplicar.");
            Console.WriteLine("4. Salir del programa.");
            Console.Write("Seleccione una opción (1-4): ");

            // Leer la opción seleccionada por el usuario
            opcion = Convert.ToInt16(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    SumarNumerosPares();
                    break;
                case 2:
                    EncontrarNumeroMasGrande();
                    break;
                case 3:
                    GenerarTablaDeMultiplicar();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 4);
    }

    static void SumarNumerosPares()
    {
        int suma = 0;
        // Sumar números pares desde 2 hasta 75
        for (int i = 2; i <= 75; i += 2)
        {
            suma += i;
        }
        Console.WriteLine($"La suma de los números pares hasta 75 es: {suma}");
    }

    static void EncontrarNumeroMasGrande()
    {
        List<int> numeros = new List<int> { 10, 5, 27, 42, 8, 56, 31, 19, 73 };
        int maximo = numeros[0];

        // Encontrar el número más grande en la lista
        foreach (int numero in numeros)
        {
            if (numero > maximo)
            {
                maximo = numero;
            }
        }

        Console.WriteLine($"El número más grande en la lista es: {maximo}");
    }

    static void GenerarTablaDeMultiplicar()
    {
        Console.Write("Ingrese un número para generar la tabla de multiplicar: ");
        int n = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"Tabla de multiplicar del {n}:");

        // Generar la tabla de multiplicar del número ingresado
        for (int i = 1; i <= 12; i++)
        {
            int resultado = n * i + 2;
            Console.WriteLine($"{n} x {i} = {resultado}");
        }
    }
}
