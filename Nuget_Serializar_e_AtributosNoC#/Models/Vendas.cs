using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerializarC_Vendas.Models
{
    public class Vendas
    {
        public Vendas(int id, string produto, decimal preco, DateTime datevenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = datevenda;
        }

        public int Id { get; set; }
        public string? Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}