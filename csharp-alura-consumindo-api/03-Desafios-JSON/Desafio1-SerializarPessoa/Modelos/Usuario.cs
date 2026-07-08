using System.Text.Json;

namespace ConsoleApp12.Modelos;

internal class Usuario
{
    public Usuario(string nome, int idade, string email)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Email = email;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public void CriaArquivoJson()
    {
        string json = JsonSerializer.Serialize(this);
        string nomeDoArquivo = $"usuario-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}
