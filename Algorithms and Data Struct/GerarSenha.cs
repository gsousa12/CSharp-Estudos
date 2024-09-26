using System;
using System.Text;

class GerarSenha
{
    public static void RunPasswordGenerator()
    { 
        int tamanhoSenha;  
        int opcao;
        string caracteres = "";

        Console.Write("Digite o tamanho da senha desejada: ");
        
        while (!int.TryParse(Console.ReadLine(), out tamanhoSenha) || tamanhoSenha <= 0)
        {
            Console.Write("Por favor, insira um número válido para o tamanho da senha: ");
        }

        Console.WriteLine("Escolha o tipo de caracteres:");
        Console.WriteLine("1 - Apenas letras maiúsculas");
        Console.WriteLine("2 - Apenas letras minúsculas");
        Console.WriteLine("3 - Letras maiúsculas e minúsculas");
        
        
        while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
        {
            Console.Write("Por favor, escolha uma opção válida: ");
        }

        
        if (opcao == 1)
        {
            caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }
        else if (opcao == 2)
        {
            caracteres = "abcdefghijklmnopqrstuvwxyz";
        }
        else if (opcao == 3)
        {
            caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        }

        StringBuilder senha = new StringBuilder();
        Random rnd = new Random();

        for (int i = 0; i < tamanhoSenha; i++)
        {
            int index = rnd.Next(0, caracteres.Length);
            senha.Append(caracteres[index]);
        }

        Console.WriteLine($"Senha gerada: {senha}");
    }
}
