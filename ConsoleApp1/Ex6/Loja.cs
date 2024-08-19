using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Ex6;

namespace ConsoleApp1.Ex6
{
    internal class Loja
    {
        public List<Produto> produtosDaLoja;

        public Loja()
        {
            produtosDaLoja = new List<Produto>();
        }

        public void addProduto(Produto produto)
        {
            produtosDaLoja.Add(produto);
        }

        public void listarProdutos() 
        {
            foreach (Produto produto2 in produtosDaLoja)
            {
                Console.WriteLine($"{produto2.getNome()},{produto2.getEstoque()},R${produto2.getPreco()}, R${produto2.valorTotal()}");
            }
        }
    }
}
