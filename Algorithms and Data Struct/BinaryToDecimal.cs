// Arquivo BinaryToDecimal.cs
using System;

public class BinaryToDecimal
{
    public static void RunBinaryToDecimal()
    {
        Console.WriteLine("Digite um número binário:");
        string binaryNumber = Console.ReadLine();

        long decimalNumber = RunBinaryToDecimalGenerator(binaryNumber);

        Console.WriteLine($"O número decimal equivalente é: {decimalNumber}");
    }

    private static long RunBinaryToDecimalGenerator(string binary)
    {
        long decimalNumber = 0;
        int power = 0;

        for (int i = binary.Length - 1; i >= 0; i--)
        {
            int digit = binary[i] - '0';
            decimalNumber += digit * (long)Math.Pow(2, power);
            power++;
        }

        return decimalNumber;
    }
}
