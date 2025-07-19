using System;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");
estados.Add("RS", "Rio Grande do Sul");


foreach (var estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
}


Console.WriteLine("==========================================");

estados.Remove("SP");

foreach (var estado in estados)
{
    Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
}
Console.WriteLine("==========================================");
string chave = "rj".ToUpper(CultureInfo.InvariantCulture);
Console.WriteLine($"Verificando a chave: {chave}");
//Verificando se a chave existe e obtendo o valor associado

if (estados.TryGetValue(chave, out string? valor))
{
    Console.WriteLine($"Valor Existente | Chave: {chave}, Valor: {valor}");
}
else
{
    Console.WriteLine($"Chave {chave} não encontrada.");
}



//Trabalhando com o modelo Pilha - LIFO (Last In, First Out) Push e Pop
/*
Stack<string> Pilha = new Stack<string>();
Pilha.Push("2");
Pilha.Push("6");
Pilha.Push("7");
Pilha.Push("9");

foreach (var item in Pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o {Pilha.Pop()} item da pilha");
foreach (var item in Pilha)
{
    Console.WriteLine(item);
}
 */

//Trabalhando com fila - FIFO (First In, First Out) Enqueue e Dequeue
/*
Queue<string> fila = new Queue<string>();
fila.Enqueue("Primeiro");
fila.Enqueue("Segundo");
fila.Enqueue("Terceiro");
fila.Enqueue("Quarto");
fila.Enqueue("Quinto");

foreach (var item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o {fila.Dequeue()} item d filaa");

foreach (var item in fila)
{
    Console.WriteLine(item);
}

 */













//new ExemploExcecao().Metodo1();
















/*
try
{



    string[] linhas = File.ReadAllLines("Arquivos/Arquivo_Leitura.txt");


    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Acesso negado ao arquivo: {ex.Message}");
}
catch (IOException ex)
{
    Console.WriteLine($"Erro de I/O: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção generica: {ex.Message}");
}
finally
{
    Console.WriteLine("Operação de leitura finalizada.");
}
 */
