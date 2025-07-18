using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades__métodos_e_construtores.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        list<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            if (Alunos == null)
            {
                Alunos = new List<Pessoa>();
            }
            Alunos.Add(aluno);
        }
    }
}