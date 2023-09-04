using System;

class Program
{
    struct Libro
    {
        public int Codigo;
        public string Titulo;
        public string ISBN;
        public string Edicion;
        public string Autor;
    }

    static Libro[] biblioteca = new Libro[100]; // Arreglo para almacenar libros
    static int totalLibros = 0; // Variable para llevar un registro del número de libros almacenados

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("Menú de la Biblioteca");
            Console.WriteLine("1. Agregar un libro");
            Console.WriteLine("2. Mostrar listado de libros");
            Console.WriteLine("3. Buscar libro por código");
            Console.WriteLine("4. Editar información de un libro");
            Console.WriteLine("5. Salir");
            Console.Write("Elija una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarLibro();
                    break;
                case 2:
                    MostrarListadoLibros();
                    break;
                case 3:
                    BuscarLibroPorCodigo();
                    break;
                case 4:
                    EditarInformacionLibro();
                    break;
                case 5:
                    Console.WriteLine("¡Adiós!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        } while (opcion != 5);
    }

    static void AgregarLibro()
    {
        if (totalLibros < biblioteca.Length)
        {
            Libro nuevoLibro;
            Console.Write("Ingrese el código del libro: ");
            nuevoLibro.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el título del libro: ");
            nuevoLibro.Titulo = Console.ReadLine();
            Console.Write("Ingrese el ISBN del libro: ");
            nuevoLibro.ISBN = Console.ReadLine();
            Console.Write("Ingrese la edición del libro: ");
            nuevoLibro.Edicion = Console.ReadLine();
            Console.Write("Ingrese el autor del libro: ");
            nuevoLibro.Autor = Console.ReadLine();

            biblioteca[totalLibros] = nuevoLibro;
            totalLibros++;
            Console.WriteLine("Libro agregado con éxito.");
        }
        else
        {
            Console.WriteLine("La biblioteca está llena. No se pueden agregar más libros.");
        }
    }

    static void MostrarListadoLibros()
    {
        if (totalLibros > 0)
        {
            Console.WriteLine("Listado de Libros:");
            Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-15} {4,-20}", "Código", "Título", "ISBN", "Edición", "Autor");
            for (int i = 0; i < totalLibros; i++)
            {
                Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-15} {4,-20}",
                                  biblioteca[i].Codigo,
                                  biblioteca[i].Titulo,
                                  biblioteca[i].ISBN,
                                  biblioteca[i].Edicion,
                                  biblioteca[i].Autor);
            }
        }
        else
        {
            Console.WriteLine("No hay libros en la biblioteca.");
        }
    }

    static void BuscarLibroPorCodigo()
    {
        Console.Write("Ingrese el código del libro a buscar: ");
        int codigoBuscado = int.Parse(Console.ReadLine());
        bool encontrado = false;

        for (int i = 0; i < totalLibros; i++)
        {
            if (biblioteca[i].Codigo == codigoBuscado)
            {
                Console.WriteLine("Información del libro:");
                Console.WriteLine("Código: {0}", biblioteca[i].Codigo);
                Console.WriteLine("Título: {0}", biblioteca[i].Titulo);
                Console.WriteLine("ISBN: {0}", biblioteca[i].ISBN);
                Console.WriteLine("Edición: {0}", biblioteca[i].Edicion);
                Console.WriteLine("Autor: {0}", biblioteca[i].Autor);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }

    static void EditarInformacionLibro()
    {
        Console.Write("Ingrese el código del libro a editar: ");
        int codigoBuscado = int.Parse(Console.ReadLine());
        bool encontrado = false;

        for (int i = 0; i < totalLibros; i++)
        {
            if (biblioteca[i].Codigo == codigoBuscado)
            {
                Console.WriteLine("Información actual del libro:");
                Console.WriteLine("Código: {0}", biblioteca[i].Codigo);
                Console.WriteLine("Título: {0}", biblioteca[i].Titulo);
                Console.WriteLine("ISBN: {0}", biblioteca[i].ISBN);
                Console.WriteLine("Edición: {0}", biblioteca[i].Edicion);
                Console.WriteLine("Autor: {0}", biblioteca[i].Autor);

                Console.WriteLine("Ingrese la nueva información del libro:");

                Console.Write("Nuevo Título: ");
                biblioteca[i].Titulo = Console.ReadLine();

                Console.Write("Nuevo ISBN: ");
                biblioteca[i].ISBN = Console.ReadLine();

                Console.Write("Nueva Edición: ");
                biblioteca[i].Edicion = Console.ReadLine();

                Console.Write("Nuevo Autor: ");
                biblioteca[i].Autor = Console.ReadLine();

                Console.WriteLine("Información del libro actualizada con éxito.");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }
}