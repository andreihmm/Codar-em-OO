using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Ex4;

/*
 
 Cenário: Gestão de Recursos na “Supermercado da Mãe” ->
• Faça um algoritmo que leia o preço e o código de 20 mercadorias presentes
em uma cesta básica. Os códigos obedecem à tabela abaixo:
• ‘l’ ou ‘L’ : limpeza
• ‘a’ ou ‘A’ : alimentação
• ‘h’ ou ‘H’ : higiene
• Calcule e imprima:
• O preço total da cesta básica; e
• Para cada código, o preço total das mercadorias presentes na cesta.
 
 */


namespace ConsoleApp1.Ex4
{
    internal class main4
    {
        static int Main(string[] args)
        {
            precoPorCod p = new();

            var lista = pegarItens();
            Console.WriteLine($"preco total = {precoTotal(lista)}");


            (double,double,double) somas = p.Calcular(lista);
            Console.WriteLine($"alimentacao = {somas.Item1}");
            Console.WriteLine($"higiene = {somas.Item2}");
            Console.WriteLine($"limpeza = {somas.Item3}");

            return 0;
        }

        static List<(char, double)> pegarItens()
        {
            List<(char, double)> cestaBasica = [];
            char cAux;
            double pAux;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n\nDigite o tipo de item:\r\n• ‘l’ ou ‘L’ : limpeza\r\n• ‘a’ ou ‘A’ : alimentação\r\n• ‘h’ ou ‘H’ : higiene");
                cAux = Convert.ToChar(value: Console.ReadLine());
                Console.WriteLine("\n\nDigite o preco!!!");
                pAux = Convert.ToDouble(Console.ReadLine());

                cestaBasica.Add((cAux, pAux));
            }
            return cestaBasica;
        }

        static double precoTotal(List<(char, double)> cestaBasica)
        {
            double total = 0;
            foreach ((char, double) m in cestaBasica)
            {
                total += m.Item2;
            }
            return total;
        }
    }
}
