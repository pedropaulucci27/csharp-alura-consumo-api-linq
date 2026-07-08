namespace ConsoleApp12.Modelos;

internal class Produto
{
    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public string? Nome { get; set; }
    public double Preco { get; set; }
}
