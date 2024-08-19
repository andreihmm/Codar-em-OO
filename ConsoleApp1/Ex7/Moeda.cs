using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ex7
{
    internal class Moeda
    {
        private double valor;
        private String nome;

        public Moeda(double v, String n)
        {
            valor = v;
            nome = n;
        }

        public double getValor()
        {
            return valor;
        }

        public String getNome()
        {
            return nome;
        }
    }
}
