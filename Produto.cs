public class Produto {
    public string Nome { get; set; }
    private int quantidadeEstoque;

    public Produto(string nome, int quantidadeInicial) {
        Nome = nome;
        quantidadeEstoque = quantidadeInicial;
    }

    public void Retirar(int quantidade) {
        if (quantidade <= quantidadeEstoque) {
            quantidadeEstoque -= quantidade;
            Console.WriteLine("Retirada de " + quantidade + " unidades realizada com sucesso.");
        }
        else {
            Console.WriteLine("Erro: Estoque insuficiente para retirada de " + quantidade + " unidades.");
        }
    }

    public void ExibirEstoque() {
        Console.WriteLine("Produto: " + Nome);
        Console.WriteLine("Estoque: " + quantidadeEstoque);
    }
}
