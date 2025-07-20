using System.Globalization;
using Tuplas_OperadorTernario_e_DesconstrucaoDeUmObjeto;
using Tuplas_OperadorTernario_e_DesconstrucaoDeUmObjeto.Models;
using Tuplas_OperadorTernario_e_DesconstrucaoDeUmObjeto.Models.Pessoa;

int numeroT = 15;
bool ehPar = false;

Console.WriteLine("IF Ternario");

ehPar = numeroT % 2 == 0;

Console.WriteLine($"O numero {numeroT} é " + (ehPar ? "par" : "impar"));


// Console.WriteLine("IF não Ternario");
// int numero = 15;

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }

// Console.WriteLine("=================================");


Pessoa p1 = new Pessoa("Bruno", "Albuquerque", 15);

(string? nome, string? sobrenome, int idade) = p1;

Console.WriteLine($"{nome} {sobrenome} \nIDADE: {idade} ANOS");




// LeituraArquivo arquivo = new LeituraArquivo();
// //O uso de " _ " é para caso a variavel não for necessaria
// var (Sucesso,LinhasArquivo ,_ //QuantidadeLinhas) = arquivo.LerArquivo("Arquivos/ArquivoLeitura.txt");

// if (Sucesso)
// {
//     Console.WriteLine("Quantidade de linhas do arquivo" + QuantidadeLinhas);
//     foreach (string linha in LinhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }




















// (int Id, string Nome, string Sobrenome , decimal Altura) tupla = (1, "Bruno", "Albuquerque",1.80M);

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Tamanho: {tupla.Altura}M");