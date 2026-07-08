namespace ConsoleApp12.Modelos;

internal class Pessoa
{
    public Pessoa(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }
}
