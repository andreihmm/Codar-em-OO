using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ex4
{
    internal class precoPorCod
    {
        public (double,double,double) Calcular(List<(char,double)> cestaBasica)
        {
            double pA = 0;
            double pH = 0;
            double pL = 0;

            foreach ((char, double) m in cestaBasica) {
                switch (m.Item1) {
                    case 'a':
                    case 'A':
                        pA += m.Item2;
                        break;
                    case 'h':
                    case 'H':
                        pH += m.Item2;
                        break;
                    case 'l':
                    case 'L':
                        pL += m.Item2;
                        break;
                    default:
                        Console.WriteLine("erro.");
                        break;
                }
            }

            (double, double, double) tuplona = (pA, pH, pL);
            return tuplona;
        }
    }
}
