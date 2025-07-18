using System;
using Propriedades__métodos_e_construtores_Pessoa.Models;
using Propriedades__métodos_e_construtores_Curso.Models;



/*P1.Nome = "Bruno";
P1.Sobrenome = "Silva";
P1.Idade = 30;

P1.Apresentar();
*/
//Exemplo de Propriedades, Métodos e Construtores  - Curso


/*
Teste sem parametros
P2.Nome = "Ana";
P2.Sobrenome = "Oliveira";
P2.Idade = 25;
*/

/*Teste sem parametros
P3.Nome = "Pedro";
P3.Sobrenome = "Oliveira";
P3.Idade = 30;
*/
Console.WriteLine("Exemplo de Propriedades, Métodos e Construtores - Curso e Pessoa");
Pessoa P1 = new Pessoa("Bruno", "Silva",30); //Com Parametros
Pessoa P2 = new Pessoa("Ana","Oliveira",25);//Com Parametros
Pessoa P3 = new Pessoa("Pedro", "Oliveira", 30);//Com Parametros

Curso Ingles = new Curso();
Ingles.Nome = "Inglês";
Ingles.AdicionarAluno(P1);
Ingles.AdicionarAluno(P2);
Ingles.AdicionarAluno(P3);
Ingles.ListaAlunos();
