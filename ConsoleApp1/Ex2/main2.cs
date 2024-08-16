using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Ex2;

namespace ConsoleApp1.Ex2
{
    internal class main2
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Qu tipo de conversao queres??");

            Console.WriteLine("CtoF: [0]");
            Console.WriteLine("CtoK: [1]");
            Console.WriteLine("FtoC: [2]");
            Console.WriteLine("FtoK: [3]");
            Console.WriteLine("KtoC: [4]");
            Console.WriteLine("KtoF: [5]");

            char op = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Digite o valor da temp ; ");
            double temp = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            conversor c = new();
            switch (op)
            {
                case '0':
                    result = c.CtoF(temp); 
                    break;
                case '1':
                    result = c.CtoK(temp);
                    break;
                case '2':
                    result = c.FtoC(temp);
                    break;
                case '3':
                    result = c.FtoK(temp);
                    break;
                case '4':
                    result = c.KtoC(temp);
                    break;
                case '5':
                    result = c.KtoF(temp);
                    break;
            }
            Console.WriteLine($"Resultado = {result}");

            return 0;
        }


    }
}
