using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv3SistemaDeJogos
{
    public abstract class Personagem
    {   public string Nome;
        public int Nivel;
        public Personagem (string NomeDoConstrutor, int NivelDoConstrutor)
        {
            Nome = NomeDoConstrutor;
            Nivel = NivelDoConstrutor;
        }
        public abstract int CalcularPoder();

        public virtual void ExibirStatus()
        {
            Console.WriteLine($"Nome do Personagem: {Nome}");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"Poder: {CalcularPoder()}");
            
            
            
        }
    }
}