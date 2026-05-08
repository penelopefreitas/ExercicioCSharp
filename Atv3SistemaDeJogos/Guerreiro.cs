using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atv3SistemaDeJogos
{
    public class Guerreiro : Personagem // <- herdando classe pai(Personagem).
    {
        public int CalcularPoder() //<- método abstrato vira método comum com corpo nas classes filhas.
        {
            return Nivel * 8 + 20; 
        }
    }
}