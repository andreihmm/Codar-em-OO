using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Exercício
• Cenário: Gestão de Pessoas no “IBGE” ->
• Escreva um algoritmo que receba a idade de um grupo de pessoas, calcule
e imprima a porcentagem de cada faixa etária em relação ao total de
pessoas.
• As faixas etárias são:
• 01 - 15 anos - A
• 16 - 30 anos - B
• 31 - 45 anos - C
• 46 - 60 anos - D
• >= 61 anos - E
• Para encerrar a entrada de dados, digite uma idade <= 0
 */

namespace Aula05.Ex1
{
    internal class Ex1
    {
        static void Main(string[] args)
        {
            //double media = Ex1.pegarMedia();
            Ex1 e1 = new();
            char classificacao = e1.classificar(e1.pegarMedia());
            Console.WriteLine($"classificacao: {classificacao}");
        }

        public double pegarMedia()
        {
            List<int> idades = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Digite sua idade!!! : ");
                int idadeAtual = Convert.ToInt32(Console.ReadLine());
                idades.Add(idadeAtual);
            }

            double media = (idades.Average());
            Console.WriteLine($"A média das idades é de: {media}");

            return media;
        }

        public char classificar(double x)
        {
            char clas;
            if (1 <= x && x <= 15)
            {
                clas = 'A';
            }
            else if (16 <= x && x <= 30)
            {
                clas = 'B';
            }
            else if(31 <= x && x <= 45)
            {
                clas = 'C';
            }
            else if(46 <= x && x <= 60)
            {
                clas = 'D';
            }
            else
            {
                clas = 'E';
            }

            return clas;
        }
    }
}
