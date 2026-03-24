using sistema_de_controle_de_produtos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_de_controle_de_produtos.Domain.Interface
{
    public interface IProdutoRepository
    {
        void Adicionar(Produto produto);
        IEnumerable<Produto> Buscar();
    }
}
