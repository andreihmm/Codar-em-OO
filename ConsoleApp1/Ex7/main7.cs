using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Ex7;

/*
 
 • Cenário: Cofrinho do Tio Patinhas -> Implementar um cofrinho de moedas
com a capacidade de receber moedas e calcular o total depositado no
cofrinho.
• Implementa uma coleção de Moeda como uma lista.
• Faça um classe de teste

 
 */

namespace ConsoleApp1.Ex7
{
    internal class main7
    {
        static int Main(string[] args)
        {
            Cofrinho cofrinho = new Cofrinho();

            Moeda m1 = new(0.25, "vinte e cinco");
            Moeda m2 = new(0.50, "cinquenta");

            cofrinho.adicionar(m1);
            cofrinho.adicionar(m2);

            Console.WriteLine($"R${cofrinho.calcularTotal()}");

            Console.WriteLine($"{cofrinho.maiorMoeda()}");
            Console.WriteLine($"{cofrinho.moedasPorValor(0.25)}");
            Console.WriteLine($"{cofrinho.numeroMoedas()}");

            return 0;
        }
    }
}
