using System;

class Program
{
    static void Main()
    {
        // se creo diccionario para almacenar precios y claves
        var preciosPorZona = new Dictionary<int, double>
        {
            { 12, 2.0 },   // América del norte
            { 15, 2.2 },   // América central
            { 18, 4.5 },   // América del sur
            { 19, 3.5 },   // Europa
            { 23, 6.0 }    // Asia
        };

        // Solicitara que se ingrese la clve y los minutos
        Console.Write("Ingrese la clave de la zona: ");
        int claveZona = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el número de minutos: ");
        double numeroMinutos = Convert.ToDouble(Console.ReadLine());

        // verificara si la zona existe
        if (preciosPorZona.ContainsKey(claveZona))
        {
            // Calcular el costo de la llamada
            double precioPorMinuto = preciosPorZona[claveZona];
            double costoLlamada = numeroMinutos * precioPorMinuto;

            // Mostrar el costo de la llamada al usuario
            Console.WriteLine($"El costo de la llamada es: {costoLlamada:C}");
        }
        else
        {
            Console.WriteLine("La clave de zona ingresada no es válida.");
        }
    }
}