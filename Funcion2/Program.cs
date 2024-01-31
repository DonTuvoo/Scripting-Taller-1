using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una frase:");
        string frase = Console.ReadLine();

        string fraseConvertida = ConvertirPalabras(frase);
        Console.WriteLine("Frase convertida:");
        Console.WriteLine(fraseConvertida);

        Console.WriteLine("Presione Enter para salir...");
        Console.ReadLine(); // Espera que el usuario presione Enter
    }

    static string ConvertirPalabras(string input)
    {
        string[] palabras = input.Split(' ');
        string resultado = "";

        foreach (string palabra in palabras)
        {
            if (palabra.Length > 0)
            {
                // Convertir la primera letra a mayúscula y el resto a minúsculas
                string palabraConvertida = char.ToUpper(palabra[0]) + palabra.Substring(1).ToLower();
                resultado += palabraConvertida + " ";
            }
        }

        return resultado.Trim(); // Elimina el espacio adicional al final
    }
}
