using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Ex5;

/*
 
 Cenário: Gestão de RH de uma Empresa -> Crie uma classe de acordo com a
representação abaixo.

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

• Os métodos simplesmente imprimem um texto (String) dizendo que eles fazem e os
parâmetros que eles recebem.
• Logo depois crie uma classe que utilize os atributos e métodos implementados
 
 */

namespace ConsoleApp1.Ex5
{
    internal class main5
    {
        static int Main(string[] args)
        {
            Funcionario f1 = new(123, "Andrei", "CEO", 2000);
            f1.cadastrar();
            f1.consultar();
            f1.atualizarSalario(4000);
            f1.listarDependentes();


            return 0;
        }
    }
}
