using System;
using System.Collections.Generic;

class DiagonalSum
{
    public static int RunDiagonalSum()
    {
        Console.WriteLine("Digite o número de linhas:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o número de colunas:");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, columns];

        Console.WriteLine("Digite os valores da matriz linha por linha, separados por espaço:");

        for (int i = 0; i < rows; i++)
        {
            string[] rowInput = Console.ReadLine().Split(' ');

            if (rowInput.Length != columns)
            {
                Console.WriteLine("A quantidade de valores fornecidos não corresponde ao número de colunas. Tente novamente.");
                i--; 
                continue;
            }

            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = Convert.ToInt32(rowInput[j]);
            }
        }

        int diagonalSum = 0;
        for (int i = 0; i < rows && i < columns; i++)
        {
            diagonalSum += matrix[i, i];
        }

        return diagonalSum;
    }

    static void RunDiagonalSumGenerator(string[] args)
    {
        int sum = RunDiagonalSum();

        Console.WriteLine("A soma dos elementos da diagonal principal é: " + sum);
        Console.ReadLine(); 
    }
}
