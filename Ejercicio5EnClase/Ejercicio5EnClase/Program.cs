using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            MostrarMenu();

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    EncontrarMayorMenor();
                    break;
                case "2":
                    AdivinarNumero();
                    break;
                case "3":
                    ContarPalabrasYVocales();
                    break;
                case "4":
                    VerificarPalindromo();
                    break;
                case "0":
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\nMENÚ:");
        Console.WriteLine("1. Encontrar el mayor y menor número");
        Console.WriteLine("2. Adivinar un número");
        Console.WriteLine("3. Contar palabras y vocales");
        Console.WriteLine("4. Verificar si una palabra es palíndromo");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opción: ");
    }

    static void EncontrarMayorMenor()
    {
        Console.WriteLine("ENCONTRAR EL MAYOR Y MENOR NÚMERO");
        int mayor = int.MinValue;
        int menor = int.MaxValue;
        int num;

        do
        {
            Console.Write("Ingrese un número positivo (0 para salir): ");
            num = int.Parse(Console.ReadLine());

            if (num > mayor)
                mayor = num;
            if (num < menor && num != 0)
                menor = num;

        } while (num != 0);

        if (mayor != int.MinValue)
            Console.WriteLine($"El número mayor ingresado es: {mayor}");
        if (menor != int.MaxValue)
            Console.WriteLine($"El número menor ingresado es: {menor}");
    }

    static void AdivinarNumero()
    {
        Console.Write("Por favor, ingrese un número cualquiera: ");
        int num = int.Parse(Console.ReadLine());

        int resultado = ((((((num * 2) + 8) * 5) - 4) / 10)-3);

        Console.WriteLine($"El número pensado por la otra persona es: {resultado}");
    }

    static void ContarPalabrasYVocales()
    {
        Console.WriteLine("CONTAR PALABRAS Y VOCALES");
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int numPalabras = palabras.Length;

        int numVocales = frase.Count(c => "aeiouáéíóúAEIOUÁÉÍÓÚ".Contains(c));

        Console.WriteLine($"Número de palabras: {numPalabras}");
        Console.WriteLine($"Número de vocales: {numVocales}");
    }

    static void VerificarPalindromo()
    {
        Console.WriteLine("VERIFICAR PALÍNDROMO");
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        bool esPalindromo = true;
        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - i - 1])
            {
                esPalindromo = false;
                break;
            }
        }

        if (esPalindromo)
            Console.WriteLine("La palabra es un palíndromo.");
        else
            Console.WriteLine("La palabra no es un palíndromo.");
    }
}
