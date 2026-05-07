using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv2SistemasDeFuncionarios
{
    public class Vendedor : Funcionario //<- Herdando classe pai (superclasse) que já traz métodos comuns (exceto abstratos) e atributos.
    {
         public override decimal CalcularSalario() // <- método era abstrato na classe pai (superclasse) e vira método comum com corpo na classe filha por ser OBRIGATÓRIO implementar.
        {
           return  SalarioBase + (SalarioBase * 0.20m);  //<-  Valor do Salário * 20% (convertido em decimal 0.20m).
        }
    }
}