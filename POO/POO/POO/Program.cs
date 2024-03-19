namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Instituicao instituicao = new Instituicao();

            System.Console.WriteLine("Informe o nome da instituição");
            instituicao.Nome = System.Console.ReadLine();

            System.Console.WriteLine("Informe o endereço da instituição");
            instituicao.Endereco = System.Console.ReadLine();

            System.Console.WriteLine("===================================");

            System.Console.WriteLine($"Obrigado por informar os dados para a {instituicao.Nome}");
            System.Console.WriteLine("Pressione qualquer tecla para encerrar.");
            System.Console.ReadKey();

        }
    }
}