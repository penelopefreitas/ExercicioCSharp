using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv3SistemaDeJogos
{
    public class Mago : Personagem
    {
         public Mago(string NomeDoConstrutor, int NivelDoConstrutor) :base(NomeDoConstrutor, NivelDoConstrutor)
        {
            
        }

        public override int CalcularPoder()
        {
            return Nivel * 10 + 20;
        }
    }
}