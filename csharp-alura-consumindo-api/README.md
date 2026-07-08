# C# — Consumindo API, Gravando Arquivos e LINQ

Repositório com os exercícios, desafios e projeto final do curso **"C#: consumindo API, gravando arquivos e LINQ"** da Alura, 4º curso da minha trilha de C#.

## 🎯 Sobre o curso

Curso focado em consumo de APIs REST com `HttpClient`, tratamento de exceções, deserialização/serialização de JSON com `System.Text.Json` e consultas com LINQ (Language Integrated Query).

## 🗂️ Estrutura do repositório

```
01-Exercicios-Iniciais/
├── Exercicio1/          → HttpClient + tratamento de exceções (DivideByZero, ArgumentOutOfRange, NullReference)
├── Exercicio2/          → Deserialização de JSON: Carro, Livro, Filme, Pais
└── ScreenSound/         → Consumo da API de músicas do Spotify + filtros e ordenação com LINQ

02-Desafios-LINQ/
├── Desafio1-NumerosUnicos/          → Distinct()
├── Desafio2-LivrosOrdenados/        → Where + Select + OrderBy
├── Desafio3-PrecoMedioProdutos/     → Average()
└── Desafio4-NumerosPares/           → Where()

03-Desafios-JSON/
├── Desafio1-SerializarPessoa/            → Serialize + File.WriteAllText
├── Desafio2-DesserializarPessoa/         → Deserialize + File.ReadAllText
├── Desafio3-SerializarListaPessoas/      → Serialize de List<T>
├── Desafio4-DesserializarListaPessoas/   → Deserialize de List<T>
└── Desafio5-FiltrarPessoasPorIdade/      → Deserialize + LINQ Where

04-Projeto-Final-ScreenSound4/
├── Modelos/
│   ├── Musica.cs             → Modelo com propriedade computada (tonalidade a partir da chave numérica)
│   └── MusicasPreferidas.cs  → Playlist por usuário, geração de JSON e TXT
├── Filtros/
│   ├── LinqFilter.cs         → Filtros por gênero, artista e tonalidade
│   └── LinqOrder.cs          → Ordenação de artistas
└── Program.cs                → Consome API pública de músicas e monta playlists favoritas
```

## 🧠 Principais conceitos aplicados

- **HttpClient**: requisições assíncronas (`GetStringAsync`) para consumo de APIs públicas
- **Tratamento de exceções**: `try/catch` específico por tipo (`DivideByZeroException`, `ArgumentOutOfRangeException`, `NullReferenceException`)
- **Serialização/Deserialização JSON**: `JsonSerializer.Serialize`/`Deserialize`, `JsonPropertyName` para mapear campos externos, `PropertyNameCaseInsensitive`
- **Leitura/escrita em arquivo**: `File.WriteAllText`, `File.ReadAllText`, `File.Exists`, `StreamWriter`
- **LINQ**: `Where`, `Select`, `OrderBy`/`OrderByDescending`, `Distinct`, `Average`, `Any`, `Take`
- **Nullable reference types**: uso de `?` e checagem de `null` após deserialização, já que `Deserialize<T>` pode retornar `null`
- **Propriedades computadas**: `tonalidade` calculada a partir de um índice (`Key`) sobre uma lista de referência
- **Clean separation of concerns**: lógica de filtro/ordenação isolada em classes `Filtros`, separada dos `Modelos` e do `Program.cs` — mesmo princípio de organização em camadas usado no projeto MinasCorporativo (Controller → Service → Repository)

## 🚀 Como executar

Cada pasta de exercício é um projeto de console independente. Para rodar:

```bash
cd 04-Projeto-Final-ScreenSound4
dotnet run
```

> Alguns exercícios pedem entrada do usuário via `Console.ReadLine()` (ex.: desafios de JSON) — rode pelo terminal para interagir.

## 📚 Trilha de cursos C# — Alura

1. [C#: Criando sua primeira aplicação](https://github.com/pedropaulucci27/csharp-alura-fundamentos)
2. [C#: Aplicando a Orientação a Objetos](https://github.com/pedropaulucci27/csharp-alura-poo)
3. [C#: Dominando a Orientação a Objetos](https://github.com/pedropaulucci27/csharp-alura-dominando-oo)
4. **C#: Consumindo API, gravando arquivos e LINQ** *(este repositório)*

---

Feito por [Pedro Paulucci Noronha](https://github.com/pedropaulucci27) — Engenharia de Software & Data Science/IA @ Ibmec BH
