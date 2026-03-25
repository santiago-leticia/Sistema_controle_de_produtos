using sistema_de_controle_de_produtos.Domain.Interface;
using sistema_de_controle_de_produtos.Infrastruture.Persistence;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace sistema_de_controle_de_produtos.Domain.Entities
{
    public class Produto : ProdutoInterface
    {
        private string Nome_Produto { get; set; }
        private decimal Preco_unitario { get; set; }
        private int Qut_estoque {  get; set; }
        private decimal Desconto { get; set; }

        //Construtor
        public Produto(string nome_produto, decimal preco_unitario, int qut_estoque, decimal desconto)
        {
            Nome_Produto = nome_produto;
            Preco_unitario = preco_unitario;
            Qut_estoque = qut_estoque;
            Desconto = desconto;
        }

        public decimal custoTotal()
        {
            return Preco_unitario * Qut_estoque;
        }

        public decimal custoFinal()
        {

            decimal CustoTotal = custoTotal();
            if (CustoTotal > 5000)
            {
                return CustoTotal - (CustoTotal * (Desconto / 100));
            }
            else
            {
                return CustoTotal;
            }
        }

        //Exisbir os valore
        public void exibirTodos(List<Produto> l)
        {
            for (int i = 0; i < l.Count; i++)
            {

                if (l[i].custoTotal() > 5000)
                {
                    Console.WriteLine(
                    $"\nNome: {l[i].Nome_Produto}" +
                    $"\nPreço Unitário: {l[i].Preco_unitario}" +
                    $"\nQuantidade: {l[i].Qut_estoque}" +
                    $"\nCusto Total: {l[i].custoTotal().ToString("F2")}" +
                    $"\nDesconto Aplicado: {l[i].Desconto}%" +
                    $"\nCusto Final: {l[i].custoFinal().ToString("F2")}");
                }
                else
                {
                    Console.WriteLine(
                    $"\nNome: {l[i].Nome_Produto}" +
                    $"\nPreço Unitário: {l[i].Preco_unitario}" +
                    $"\nQuantidade: {l[i].Qut_estoque}" +
                    $"\nCusto Total: {l[i].custoTotal().ToString("F2")}" +
                    $"\nSem desconto aplicado." +
                    $"\nCusto final: {l[i].custoFinal().ToString("F2")}");
                }
            }
            decimal maiorValorPossivel = -1;
            string nm_Produto = null;
            for (int i = 0;i < l.Count; i++)
            {
                if(l[i].custoFinal() > maiorValorPossivel)
                {
                    maiorValorPossivel = l[i].custoFinal();
                    nm_Produto = l[i].Nome_Produto;
                }
            }
            Console.WriteLine($"O produto com maior custo final é: {nm_Produto}");
        }
    }
}
