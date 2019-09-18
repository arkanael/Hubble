using System;
using System.Collections.Generic;
using System.Text;

namespace Hubble.Entities
{
    public class Estoque
    {
        public Estoque(int idEstoque, string nome)
        {
            IdEstoque = idEstoque;
            Nome = nome;
        }

        public int IdEstoque { get; set; }
        public string Nome { get; set; }
        public IList<Produto> Produtos { get; set; }
    }
}
