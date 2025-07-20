using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas_OperadorTernario_e_DesconstrucaoDeUmObjeto.Models.Pessoa
{
    // Classe Pessoa
    public class Pessoa
    {
        // Metodo Construtor

        public Pessoa(string? nome, string? sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        public void Deconstruct(out string? nome, out string? sobrenome, out int idade)
        {
            nome = Nome;
            sobrenome = Sobrenome;
            idade = Idade;

        }

        private string? _nome;
        private string? _sobrenome;
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
        public string? Sobrenome
        {

            get => _sobrenome?.ToUpper();


            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException(nameof(Sobrenome), "Sobrenome não pode ser nulo.");
                }
                _sobrenome = value;
            }
        }

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