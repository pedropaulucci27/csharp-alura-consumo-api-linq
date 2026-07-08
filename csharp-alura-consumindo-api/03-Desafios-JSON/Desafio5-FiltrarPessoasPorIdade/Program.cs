// Desafio 5 — Lê um arquivo JSON com informações de várias pessoas,
// permite inserir uma idade e exibe as pessoas com aquela idade.
using ConsoleApp12.Modelos;
using System.Text.Json;

string fileName = "pessoas.json";

if (File.Exists(fileName))
{
    string json = File.ReadAllText(fileName);
    List<Pessoa>? listaPessoas = JsonSerializer.Deserialize<List<Pessoa>>(json);

    if (listaPessoas != null)
    {
        Console.WriteLine("Procure pessoas pela idade: ");
        int idade = int.Parse(Console.ReadLine()!);

        List<Pessoa> novaLista = listaPessoas.Where(p => p.Idade == idade).ToList();
        if (novaLista.Any())
        {
            foreach (Pessoa pessoa in novaLista)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma pessoa encontrada!");
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
