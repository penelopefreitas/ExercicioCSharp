using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv2SistemasDeFuncionarios
{
    public class Gerente : Funcionario //<- Herdando Classe Funcionario para classe Gerente.
    {   
         public Gerente(string NomeDoConstrutor, decimal SalarioBaseDoConstrutor) :base( NomeDoConstrutor,  SalarioBaseDoConstrutor) //<- No construtor, DECLARAMOS as variaveis (ex: string, int, decimal). Em base apenas ENVIAMOS o construtor.
        {
            
        }
        public override decimal CalcularSalario() // <- método era abstrato na classe pai (superclasse) e vira método comum com corpo na classe filha por ser OBRIGATÓRIO implementar.
        {
            return SalarioBase + (SalarioBase * 0.50m); 
            
        }
    }
}