

namespace POO_ATV_ProfGuilherme
{
    public class Carro : Veiculo // <- classe filha (Carro) herdando a classe pai (Veiculo).
    { 
        public override double CalcularRevisao() // <- método, que antes era abstrato na classe pai, vira um método comum nas classes FILHAS por ser OBRIGATÓRIO implementar.
        {
            return 500;
        }

    }
}