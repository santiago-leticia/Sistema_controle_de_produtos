using sistema_de_controle_de_produtos.Domain.Entities;
using sistema_de_controle_de_produtos.Domain.Interface;
using sistema_de_controle_de_produtos.Infrastruture.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_de_controle_de_produtos.Application.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        //cadastrar Produto
        public void CadastrarProduto(string nome_Produto, 
            decimal preco_unitario, int qut_estoque, decimal desconto)
        {
            Produto p = new Produto(nome_Produto, preco_unitario, qut_estoque, desconto);
            _produtoRepository.Adicionar(p);
        }

        //Lista
        public void ListagemProduto()
        {
            var produtos = _produtoRepository.Buscar();

            List <Produto> l = new List<Produto>(produtos);
            if (l.Count > 0)
            {
                l[0].exibirTodos(l);
            }
        }
    }
}
