using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades__métodos_e_construtores_Pessoa.Models
{
    // Classe Pessoa
    public class Pessoa
    {
        // Metodo Construtor
    public Pessoa(string? nome, string? sobrenome,int idade)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Idade = idade;
    }
        private string? _nome;
        private int _idade;
        // Propriedades
        public string? Nome
        {
            get => _nome?.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException(nameof(Nome), "Nome não pode ser nulo.");
                }
                _nome = value;
            }
        }
        public string? Sobrenome { get; set; }

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Idade), "Idade não pode ser negativa.");
                }
                _idade = value;
            }
        } // Propriedade com get e set

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome?.ToUpper()} {Sobrenome?.ToUpper()}, Idade: {Idade}");
        }
    }
}