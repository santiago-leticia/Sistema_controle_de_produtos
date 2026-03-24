using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_de_controle_de_produtos.Domain.Interface
{
    public interface ProdutoInterface
    {
        decimal custoTotal();

        decimal custoFinal();
    }
}
