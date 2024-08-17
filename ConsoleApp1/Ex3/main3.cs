using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 
Cenário: Verão Capixaba 02 ->
• Os comerciantes das Praias de Vila-Velha querem saber a temperatura média do verão
capixaba.
• Para isso é necessário escrever um algoritmo que leia a temperatura diária no verão,
durante 15 dias, e exiba a temperatura média da estação.
• Deve impedir a entrada de dados de uma temperatura fora da estação.
• Sabe-se que as temperaturas, na estação de verão Capixaba, ficam acima de 28 °C. 

 */
namespace ConsoleApp1.Ex3
{
    internal class main3
    {
        static int Main(string[] args)
        {
            var media = pegarTemps();

            switch (eVerao(media))
            {
                case true:
                    Console.WriteLine("eh verao meu povo");
                    break;
                case false:
                    Console.WriteLine("chorem mais.");
                    break;
            }
            return 0;
        }

        static public double pegarTemps()
        {
            List<double> temps = [];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite a temperatura atual!!!");
                temps.Add(Convert.ToDouble(Console.ReadLine()));
            }
            return temps.Average();
        }

        static public bool eVerao(double val) {
            return val switch
            {
                > 28 => true,
                _ => false
            };
        }
    }
}
