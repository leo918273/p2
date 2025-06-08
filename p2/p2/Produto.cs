using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    public class Produto
    {
        public int Id { get; }
        public string Nome { get; }
        public decimal Preco { get; }
        public string Categoria { get; }

        public Produto(int id, string nome, decimal preco, string categoria)
        {
            if (preco <= 0)
                throw new ArgumentException("O preço do produto deve ser maior que zero.");

            Id = id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }
    }

}
