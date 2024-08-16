using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ex2
{
    internal class conversor
    {
        public double CtoF(double C)
        {
            double F = (C * 1.8) + 32;
            return F;
        }

        public double CtoK(double C)
        {
            double K = C + 273.15;
            return K;
        }

        public double FtoC(double F)
        {
            double C = (F - 32) / 1.8;
            return C;
        }

        public double KtoC(double K)
        {
            double C = K - 273.15;
            return C;
        }

        public double FtoK(double F)
        {
            double K = CtoK(FtoC(F));
            return K;
        }

        public double KtoF(double K)
        {
            double F = CtoF(KtoC(K));
            return F;
        }
    }
}
