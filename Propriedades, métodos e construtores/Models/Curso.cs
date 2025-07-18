using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Propriedades__métodos_e_construtores_Pessoa.Models;

namespace Propriedades__métodos_e_construtores_Curso.Models
{
    public class Curso
    {
        public string? Nome { get; set; }
        List<Pessoa> Alunos { get; set; } = new List<Pessoa>();

        public void AdicionarAluno(Pessoa aluno)
        {
            if (Alunos == null)
            {
                Alunos = new List<Pessoa>();
            }
            Alunos.Add(aluno);
        }
        public void ListaAlunos()
        {
            Console.WriteLine($"Alunos do curso {Nome?.ToUpper()}");
            foreach (var aluno in Alunos)
            {
                aluno.Apresentar();
            }
        }
        
    }
}