using System;
using System.Collections.Generic;
using System.Text;

namespace Hubble.Entities
{
    public class Produto
    {
        public Produto(int idProduto, string nome, int quantidade, DateTime dataCadastro, int idEstoque)
        {
            IdProduto = idProduto;
            Nome = nome;
            Quantidade = quantidade;
            DataCadastro = dataCadastro;
            IdEstoque = idEstoque;
        }

        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdEstoque { get; set; }
        public Estoque Estoque { get; set; }
    }
}
