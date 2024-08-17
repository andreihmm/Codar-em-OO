using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
 Class: Funcionario

Attributes:

matricula: int
nome: String
cargoAtual: String
salarioAtual: float
Methods:

+ cadastrar(): void
+ consultar(): void
+ atualizarSalario(novoSalario: float): void
+ listarDependentes(): void
 
 */

namespace ConsoleApp1.Ex5
{
    internal class Funcionario
    {
        private int matricula { get; set; }
        private String name { get; set; }
        private String cargoAtual { get; set; }
        private float salarioAtual { get; set; }

        public Funcionario(int matricula, String name, String cargoAtual, float salarioAtual)
        {
            this.matricula = matricula;
            this.name = name;
            this.cargoAtual = cargoAtual;
            this.salarioAtual = salarioAtual;
        }


        public void cadastrar()
        {
            Console.WriteLine("Para cadastrar é necessário: matricula: int\r\nnome: String\r\ncargoAtual: String\r\nsalarioAtual: float");
        }
        public void consultar() 
        {
            Console.WriteLine("Insira a matricula...");
            
        }

        public void atualizarSalario(float novoSalario) 
        {
            salarioAtual = novoSalario;
        }

        public void listarDependentes() 
        {
            Console.WriteLine("Insira a matricula...");

        }
    }
}
