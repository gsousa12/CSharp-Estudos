class InverterPalavras
{

    public static  void RunPhaseInverter()
    {
        Console.WriteLine("Digite uma frase: ");
        string fraseDigitada = Console.ReadLine();

        string fraseDigitadaInvertida = InverterOrdemPalavras(fraseDigitada);
        Console.WriteLine(fraseDigitadaInvertida);

        Console.ReadLine();
    }

    static string InverterOrdemPalavras(string fraseDigitada)
    {
        string[] palavras = fraseDigitada.Split(' '); // Divide a frase em palavras

        Array.Reverse(palavras); // Inverte a ordem dads palavras

        return string.Join(" ", palavras); // Reune as palavras de volta em uma frase
    }

}