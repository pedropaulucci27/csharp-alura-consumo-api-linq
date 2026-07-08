// Desafio 4 — Lê um arquivo JSON com informações de várias pessoas,
// desserializa em uma lista e exibe na tela.
using ConsoleApp12.Modelos;
using System.Text.Json;

string fileName = "pessoas.json";

if (File.Exists(fileName))
{
    string json = File.ReadAllText(fileName);
    List<Pessoa>? listaPessoas = JsonSerializer.Deserialize<List<Pessoa>>(json);

    if (listaPessoas != null)
    {
        foreach (Pessoa pessoa in listaPessoas)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
        }
    }
    else
    {
        Console.WriteLine("Não foi possível ler a lista de pessoas.");
    }
}
else
{
    Console.WriteLine($"O arquivo {fileName} não existe!");
}
