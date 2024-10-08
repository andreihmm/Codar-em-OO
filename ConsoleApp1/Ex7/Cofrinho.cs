﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Ex7
{
    internal class Cofrinho
    {
        public List<Moeda> cofres;
        public Cofrinho()
        {
            cofres = new List<Moeda>();
        }

        public void adicionar(Moeda m)
        {
            cofres.Add(m);
        }

        public double calcularTotal()
        {
            double total = 0;
            foreach (Moeda m in cofres)
            {
                total += m.getValor();
            }
            return total;
        }

        public int numeroMoedas()
        {
            return cofres.Count;
        }

        public int moedasPorValor(double valor)
        {
            return cofres.Where(m => m.getValor() == valor).Count();
        }

        public double maiorMoeda()
        {
            return cofres.Max(m => m.getValor());
        }
    }
}
