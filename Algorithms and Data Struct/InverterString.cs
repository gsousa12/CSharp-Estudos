class inverterString
{
    public static void RunStringInverter()
    {
        Console.WriteLine("Digite uma String: ");
        string input = Console.ReadLine();

        string reversedString = InverterString(input);

        Console.WriteLine("Sua String invertida = " + reversedString);
    }

    public static string InverterString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}