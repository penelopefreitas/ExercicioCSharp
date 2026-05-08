using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv3SistemaDeJogos
{
    public  class Guerreiro : Personagem
    {
        public Guerreiro(string NomeDoConstrutor, int NivelDoConstrutor) :base(NomeDoConstrutor, NivelDoConstrutor)
        {
            
        }

        public override int CalcularPoder()
        {
            return Nivel * 10;
        }
       
    }
}