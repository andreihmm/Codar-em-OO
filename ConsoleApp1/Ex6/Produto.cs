using System;

namespace ConsoleApp1.Ex6
{

    /*

    • nome (String): o nome do produto.
    • preco (double): o preço do produto.
    • estoque (int): a quantidade de produtos em estoque.

     */

    public class Produto
    {
        public String nome;
        public double preco;
        public int estoque;

        public Produto(String nome, double preco, int estoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.estoque = estoque;
        }

        public String getNome() 
        {
            return nome;
        }

        public double getPreco() {
            return preco;
        }
        public int getEstoque() { 
            return estoque;
        }

        public void setNome(String nome) { 
            this.nome = nome;
        }

        public void setPreco(int preco)
        {

            this.preco = preco;
        }
        public void setEstoque(int estoque)
        {
            this.estoque = estoque;
        }

        public double valorTotal()
        {
            return preco * estoque;
        }
    }
}