

namespace Atv3SistemaDeJogos
{
    public abstract class Personagem
    {
        public string Nome; // <- atributo público do tipo texto.
        public int Nivel;   //<- atributo público do tipo númerico inteiro.

        public abstract int CalcularPoder(); //<- Método abstrato sem corpo por estar na classe pai.

        public void ExibirStatus(){ //<- Método comum com corpo.
            Console.WriteLine($"Personagem: {Nome}.");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"Poder: {CalcularPoder()}");
        }
    }
}