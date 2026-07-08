// Desafio 2 — Lê um arquivo JSON com informações de uma pessoa,
// desserializa e exibe na tela.
using ConsoleApp12.Modelos;
using System.Text.Json;

string nomeDoArquivo = "pessoa.json";

if (File.Exists(nomeDoArquivo))
{
    string jsonString = File.ReadAllText(nomeDoArquivo);
    Pessoa? pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);

    if (pessoa != null)
    {
        Console.WriteLine($"Nome: {pessoa.Nome}");
        Console.WriteLine($"Idade: {pessoa.Idade}");
    }
    else
    {
        Console.WriteLine("Não foi possível ler os dados da pessoa.");
    }
}
else
{
    Console.WriteLine($"O arquivo {nomeDoArquivo} não existe.");
}
