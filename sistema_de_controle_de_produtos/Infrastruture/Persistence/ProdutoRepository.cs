using sistema_de_controle_de_produtos.Domain.Entities;
using sistema_de_controle_de_produtos.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_de_controle_de_produtos.Infrastruture.Persistence
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly List<Produto> produtos = new();

        //Adicionar informacoes na lista
        public void Adicionar(Produto produto)
        {
            produtos.Add(produto);
        }

        //Buscar Informacao da lista
        public IEnumerable<Produto> Buscar()
        {
            return produtos;
        }


    }
}
