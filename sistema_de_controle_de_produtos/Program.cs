using sistema_de_controle_de_produtos.Application.Services;
using sistema_de_controle_de_produtos.Domain.Entities;
using sistema_de_controle_de_produtos.Infrastruture.Persistence;

namespace sistema_de_controle_de_produtos
{
    public class Program
    {
        static void Main(string[] args)
        {
            var repository = new ProdutoRepository();
            var service = new ProdutoService(repository);

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nProduto {i+1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço Unitário: ");
                decimal preco_unitario = decimal.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Console.Write("Desconto: ");
                decimal desconto = decimal.Parse(Console.ReadLine());

                service.CadastrarProduto(nome, preco_unitario, quantidade, desconto);

            }
            service.ListagemProduto();

            Console.ReadKey();

        }
    }
}