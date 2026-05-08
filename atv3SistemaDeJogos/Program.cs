namespace atv3SistemaDeJogos;

class Program
{
    static void Main(string[] args)
    {
        List<Personagem> variavel1 = new List<Personagem>()
        {
            new Guerreiro("Jinx", 40),
            new Mago("Veigar", 80)
        };

        foreach(Personagem personagens in variavel1)
        {
            personagens.ExibirStatus();
        }
    }
}
