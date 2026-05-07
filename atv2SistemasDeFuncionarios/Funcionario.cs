using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv2SistemasDeFuncionarios
{
    public abstract class Funcionario
    {
        public string Nome;
        public decimal SalarioBase;

        public abstract decimal CalcularSalario();

        public void ExibirResumo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salário: {SalarioBase:C}");
            Console.WriteLine($"Salário + Comissão: {CalcularSalario():C}");

            
        }
    }
}