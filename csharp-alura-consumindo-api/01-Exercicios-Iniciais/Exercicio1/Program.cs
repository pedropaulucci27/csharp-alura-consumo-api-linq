// Exercício 1 — Requisição HTTP com HttpClient
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Request error: {ex.Message}");
    }
}

// Exercício 2 — Divisão com tratamento de DivideByZeroException
try
{
    Console.WriteLine("Digite um numerador inteiro: ");
    int numerador = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite um denominador inteiro: ");
    int denominador = int.Parse(Console.ReadLine());

    int divisao = numerador / denominador;
    Console.WriteLine(divisao);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro: divisão por 0.");
}

// Exercício 3 — Índice inexistente com ArgumentOutOfRangeException
try
{
    List<int> inteiros = new List<int> { 1, 2, 3, 4, 5 };
    Console.WriteLine($"Elemento do índice 5: {inteiros[5]}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Erro: Índice inexistente.");
}

// Exercício 4 — Objeto nulo com NullReferenceException
try
{
    MinhaClasse objetoNulo = null;
    objetoNulo.MeuMetodo();
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Erro: objeto nulo.");
}

public class MinhaClasse
{
    public void MeuMetodo()
    {
        Console.WriteLine("Olá, mundo!");
    }
}
