using POO;

CarrinhoItem bola = new CarrinhoItem();

bola.nome = "Bola";
bola.quantidade = 10;
bola.preco = 20.0;

CarrinhoItem camisa = new CarrinhoItem();

camisa.nome = "Camisa";
camisa.quantidade = 20;
camisa.preco = 30.0;

Console.WriteLine("\n" + bola.nome);


CarrinhoItem2 sapato = new CarrinhoItem2();

sapato.Nome = "";
sapato.Quantidade = 0;
sapato.Preco = 0;

Console.WriteLine("\n" + sapato.Quantidade);
Console.WriteLine("\n" + sapato.Preco);