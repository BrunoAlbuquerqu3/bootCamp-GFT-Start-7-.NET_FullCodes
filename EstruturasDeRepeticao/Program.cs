using System;
using EstruturaDeRepeticao.Models;
using OperadoresAritmeticos.Models;

Calculadora calc = new Calculadora();

//Referencias de Outro Projeto
Console.WriteLine("Referencia do Projeto Operadores aritméticos");
calc.Somar(10, 30);
calc.Dividir(10, 2);

MinhasEstruturas estruturas = new MinhasEstruturas();

Console.WriteLine("\n Exercicio 1");
estruturas.ExemploFOR(10); // Escolha um numero para ver as Multiplicações do 1 ao 10
Console.WriteLine("\nPressione ENTER para continuar para o próximo exercício...");
Console.ReadLine();

Console.WriteLine("\n Exercicio 2");
estruturas.ExemploWhile(30); // Escolha um numero para ver as Multiplicações do 1 ao 10
Console.WriteLine("\nPressione ENTER para continuar para o próximo exercício...");
Console.ReadLine();

Console.WriteLine("\n Exercicio 3");
estruturas.ExemploDoWhile(); // Responsavel por somar números digitados
Console.WriteLine("\nPressione ENTER para continuar para o próximo exercício...");
Console.ReadLine();

Console.WriteLine("\n Exercicio 4"); // Opções para Cadastro
estruturas.ExemploWhileSwitchCase();
/*Aqui estou testando 4 opções | 
 1 - Cadastrar Cliente, 2 - Buscar Cliente, 3 - Apagar Cliente, 4 - Encerrar*/
Console.WriteLine("\nPressione ENTER para continuar para o próximo exercício...");
Console.ReadLine();

Console.WriteLine("Todos os codigos foram executados");