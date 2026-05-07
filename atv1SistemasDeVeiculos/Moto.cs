using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_ATV_ProfGuilherme
{
    public class Moto : Veiculo
    {
        public override double CalcularRevisao() // <- método, que antes era abstrato na classe pai, vira um método comum nas classes FILHAS por ser OBRIGATÓRIO implementar.
        {
            return 300;
        }
    }
}