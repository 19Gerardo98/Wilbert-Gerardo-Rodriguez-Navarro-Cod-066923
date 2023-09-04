using System;

class Program
{
    static void Main()
    {
        // Definir arreglos para almacenar los datos de la canción
        string[] artistas = new string[10];
        string[] titulos = new string[10];
        int[] duraciones = new int[10];
        int[] tamanos = new int[10];

        // Contador para llevar un registro de las canciones ingresadas
        int contadorCanciones = 0;

        // Bucle para permitir al usuario ingresar datos de canciones hasta 10 canciones
        while (contadorCanciones < 10)
        {
            Console.WriteLine("Ingrese los datos de la canción:");

            // Pedir al usuario los datos de la canción
            Console.Write("Artista: ");
            string artista = Console.ReadLine();

            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Duración (en segundos): ");
            int duracion;
            if (int.TryParse(Console.ReadLine(), out duracion))
            {
                // Validar que la duración sea un número válido
                if (duracion < 0)
                {
                    Console.WriteLine("La duración debe ser un número positivo.");
                    continue; // Volver a pedir los datos
                }
            }
            else
            {
                Console.WriteLine("Ingrese una duración válida.");
                continue; // Volver a pedir los datos
            }

            Console.Write("Tamaño del fichero (en KB): ");
            int tamano;
            if (int.TryParse(Console.ReadLine(), out tamano))
            {
                // Validar que el tamaño sea un número válido
                if (tamano < 0)
                {
                    Console.WriteLine("El tamaño debe ser un número positivo.");
                    continue; // Volver a pedir los datos
                }
            }
            else
            {
                Console.WriteLine("Ingrese un tamaño válido.");
                continue; // Volver a pedir los datos
            }

            // Almacenar los datos en los arreglos
            artistas[contadorCanciones] = artista;
            titulos[contadorCanciones] = titulo;
            duraciones[contadorCanciones] = duracion;
            tamanos[contadorCanciones] = tamano;

            // Incrementar el contador de canciones
            contadorCanciones++;

            // Preguntar al usuario si desea ingresar otra canción
            Console.Write("¿Desea ingresar otra canción? (S/N): ");
            string respuesta = Console.ReadLine();

            if (respuesta.ToUpper() != "S")
            {
                break; // Salir del bucle si la respuesta no es "S"
            }
        }

        // Mostrar los datos de las canciones ingresadas
        Console.WriteLine("\nDatos de las canciones ingresadas:");
        for (int i = 0; i < contadorCanciones; i++)
        {
            Console.WriteLine($"Canción {i + 1}:");
            Console.WriteLine($"Artista: {artistas[i]}");
            Console.WriteLine($"Título: {titulos[i]}");
            Console.WriteLine($"Duración (en segundos): {duraciones[i]}");
            Console.WriteLine($"Tamaño del fichero (en KB): {tamanos[i]}");
            Console.WriteLine();
        }
    }
}
