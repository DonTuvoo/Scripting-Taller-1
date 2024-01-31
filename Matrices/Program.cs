using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el tamaño de las matrices (n):");
        int n = int.Parse(Console.ReadLine());

        // Definir la matriz A
        int[,] A = new int[n, n];
        Console.WriteLine("Ingrese los elementos de la matriz A:");
        LeerMatriz(A);

        // Definir la matriz B
        int[,] B = new int[n, n];
        Console.WriteLine("Ingrese los elementos de la matriz B:");
        LeerMatriz(B);

        // Inicializar una matriz para almacenar el resultado
        int[,] C = new int[n, n];

        // Sumar las matrices A y B
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                C[i, j] = A[i, j] + B[i, j];
            }
        }

        // Imprimir la suma de las matrices
        Console.WriteLine("\nLa suma de las matrices es:");
        ImprimirSumaMatrices(A, B, C);

        // Esperar a que el usuario presione una tecla antes de salir
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }

    static void LeerMatriz(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Ingrese el elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void ImprimirSumaMatrices(int[,] A, int[,] B, int[,] C)
    {
        int n = A.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            Console.Write("+ ");
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{B[i, j]} ");
            }
            Console.Write("= ");
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{C[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
