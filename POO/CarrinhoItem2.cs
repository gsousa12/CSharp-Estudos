namespace POO
{
    public class CarrinhoItem2
    {
        public string Nome { get; set; }
        private int _quantidade;

        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value > 0)
                {
                    _quantidade = value;
                }
                else
                {
                    _quantidade = 1;
                }
            }
        }
        private double _preco;

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0)
                {
                    _preco = value;

                }
                else
                {
                    _preco = 1;
                }
            }
        }

        // Construtor da classe

        public CarrinhoItem2()
        {
            _quantidade = 1;
            _preco = 1;
        }
        public CarrinhoItem2(string nome, double preco) : base()
        {
            Nome = nome;
            _quantidade = 1;
            _preco = preco;
        }
    }
}
