// Desafio 3 — Permite inserir informações de várias pessoas, armazena
// em uma lista, serializa em JSON e salva em um arquivo.
using ConsoleApp12.Modelos;
using System.Text.Json;

int opcao;
List<Pessoa> pessoas = new();
do
{
    Console.WriteLine("Digite o nome de uma pessoa");
    string nome = Console.ReadLine()!;
    Console.WriteLine($"Digite a idade da pessoa {nome}");
    int idade = int.Parse(Console.ReadLine()!);
    Pessoa p = new(nome, idade);
    pessoas.Add(p);

    Console.WriteLine("Digite 0 para parar de cadastrar pessoas!");
    opcao = int.Parse(Console.ReadLine()!);
}
while (opcao != 0);

string json = JsonSerializer.Serialize(pessoas);
string fileName = "pessoas.json";
File.WriteAllText(fileName, json);
Console.WriteLine("O arquivo JSON foi criado com sucesso!");
