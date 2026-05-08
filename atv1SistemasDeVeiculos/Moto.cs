
namespace POO_ATV_ProfGuilherme
{
    public class Moto : Veiculo
    {   
        public Moto (string ModeloDoConstrutor, int AnoDoConstrutor): base(ModeloDoConstrutor, AnoDoConstrutor ) //- OBS: O nome do construtor deve ser o mesmo da classe.
        {
            
        }
        public override double CalcularRevisao() // <- método, que antes era abstrato na classe pai, vira um método comum nas classes FILHAS por ser OBRIGATÓRIO implementar.
        {
            return 300;
        }
    }
}