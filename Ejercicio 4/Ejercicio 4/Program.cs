
using System;

class Alumno
{
    public int Codigo { get; set; }
    public string NombreCompleto { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Grado { get; set; }
    public int AnioRegistro { get; set; }
}

class Program
{
    static Alumno[] alumnos = new Alumno[100]; // Arreglo para almacenar alumnos
    static int cantidadAlumnos = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Gestión de Alumnos");
            Console.WriteLine("1. Agregar un alumno");
            Console.WriteLine("2. Mostrar listado de alumnos");
            Console.WriteLine("3. Buscar alumno por código");
            Console.WriteLine("4. Editar información de un alumno por código");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarAlumno();
                    break;
                case 2:
                    MostrarListadoAlumnos();
                    break;
                case 3:
                    BuscarAlumnoPorCodigo();
                    break;
                case 4:
                    EditarAlumnoPorCodigo();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void AgregarAlumno()
    {
        Console.WriteLine("Ingrese los datos del alumno:");
        Alumno alumno = new Alumno();

        Console.Write("Código: ");
        alumno.Codigo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nombre completo: ");
        alumno.NombreCompleto = Console.ReadLine();

        Console.Write("Fecha de nacimiento (yyyy-MM-dd): ");
        alumno.FechaNacimiento = DateTime.Parse(Console.ReadLine());

        Console.Write("Grado: ");
        alumno.Grado = Console.ReadLine();

        Console.Write("Año de registro: ");
        alumno.AnioRegistro = Convert.ToInt32(Console.ReadLine());

        alumnos[cantidadAlumnos] = alumno;
        cantidadAlumnos++;

        Console.WriteLine("Alumno agregado exitosamente.");
    }

    static void MostrarListadoAlumnos()
    {
        Console.WriteLine("Listado de Alumnos:");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("| Código | Nombre Completo       | Fecha de Nacimiento | Grado  | Año de Registro |");
        Console.WriteLine("---------------------------------------------------------");

        for (int i = 0; i < cantidadAlumnos; i++)
        {
            Console.WriteLine($"| {alumnos[i].Codigo,-6} | {alumnos[i].NombreCompleto,-21} | {alumnos[i].FechaNacimiento.ToString("yyyy-MM-dd"),-19} | {alumnos[i].Grado,-6} | {alumnos[i].AnioRegistro,-15} |");
        }

        Console.WriteLine("---------------------------------------------------------");
    }

    static void BuscarAlumnoPorCodigo()
    {
        Console.Write("Ingrese el código del alumno a buscar: ");
        int codigoBuscado = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cantidadAlumnos; i++)
        {
            if (alumnos[i].Codigo == codigoBuscado)
            {
                Console.WriteLine("Información del alumno encontrado:");
                Console.WriteLine("Código: " + alumnos[i].Codigo);
                Console.WriteLine("Nombre Completo: " + alumnos[i].NombreCompleto);
                Console.WriteLine("Fecha de Nacimiento: " + alumnos[i].FechaNacimiento.ToString("yyyy-MM-dd"));
                Console.WriteLine("Grado: " + alumnos[i].Grado);
                Console.WriteLine("Año de Registro: " + alumnos[i].AnioRegistro);
                return;
            }
        }

        Console.WriteLine("Alumno no encontrado con ese código.");
    }

    static void EditarAlumnoPorCodigo()
    {
        Console.Write("Ingrese el código del alumno a editar: ");
        int codigoBuscado = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cantidadAlumnos; i++)
        {
            if (alumnos[i].Codigo == codigoBuscado)
            {
                Console.WriteLine("Información actual del alumno:");
                Console.WriteLine("Código: " + alumnos[i].Codigo);
                Console.WriteLine("Nombre Completo: " + alumnos[i].NombreCompleto);
                Console.WriteLine("Fecha de Nacimiento: " + alumnos[i].FechaNacimiento.ToString("yyyy-MM-dd"));
                Console.WriteLine("Grado: " + alumnos[i].Grado);
                Console.WriteLine("Año de Registro: " + alumnos[i].AnioRegistro);

                Console.WriteLine("Ingrese los nuevos datos del alumno:");

                Console.Write("Nombre completo: ");
                alumnos[i].NombreCompleto = Console.ReadLine();

                Console.Write("Fecha de nacimiento (yyyy-MM-dd): ");
                alumnos[i].FechaNacimiento = DateTime.Parse(Console.ReadLine());

                Console.Write("Grado: ");
                alumnos[i].Grado = Console.ReadLine();

                Console.Write("Año de registro: ");
                alumnos[i].AnioRegistro = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Alumno editado exitosamente.");
                return;
            }
        }

        Console.WriteLine("Alumno no encontrado con ese código.");
    }
}