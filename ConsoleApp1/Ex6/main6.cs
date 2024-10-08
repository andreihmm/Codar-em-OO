﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Ex6;

/*
 
 Cenário: Uma Loja de Roupas online -> Você foi contratado para desenvolver
um software para gerenciar as vendas de uma loja de roupas online. Para isso,
você precisa implementar uma classe Produto e instanciar objetos dessa classe
para representar cada item de roupa disponível na loja.
• Crie uma classe Produto com os seguintes atributos:
• nome (String): o nome do produto.
• preco (double): o preço do produto.
• estoque (int): a quantidade de produtos em estoque.
• Implemente Construtores
• Implemente métodos para:
• Obter e atualizar os dados da classe
• Um método para calcular o valor total de produtos no estoque
• Crie uma classe Loja para instanciar e manipular 3 produtos diferentes dessa
loja.
 
 */


namespace ConsoleApp1.Ex6
{
    internal class main6
    {
        static int Main(string[] args)
        {
            Loja loja = new();
            Produto produto1 = new("bone", 20, 100);

            Produto produto2 = new("bucket", 50,20);

            Produto produto3 = new("uniforme", 1, 100);

            loja.addProduto(produto1);
            loja.addProduto(produto2);
            loja.addProduto(produto3);

            loja.listarProdutos();


            return 0;
        }
    }
}
