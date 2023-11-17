namespace POO
{
    public class CarrinhoItem2
    {
        private string _nome;
        // private int _quantidade;
        private double _preco;

        /*
        public string getNome()
        {
            return _nome;
        }

        public void setNome(string nome)
        {
            if (String.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome não pode ser vazio");
            }
            this._nome = nome;

        }
        */

        // GET E SET no Csharp

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome não pode ser vazio");
                }
                this._nome = value;
            }
        }

        public int Quantidade { get; set; }

    }
}