// Desafio 1 — Permite ao usuário inserir informações de uma pessoa
// (nome, idade, e-mail), serializa em JSON e salva em um arquivo.
using ConsoleApp12.Modelos;

Console.Write("Nome: ");
string nome = Console.ReadLine()!;

Console.Write("Idade: ");
int idade = int.Parse(Console.ReadLine()!);

Console.Write("E-mail: ");
string email = Console.ReadLine()!;

Usuario usuario1 = new(nome, idade, email);
usuario1.CriaArquivoJson();
