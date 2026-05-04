

namespace POO
{
    public class Moto : Veiculo
    {
        public bool TemPartidaEletrica;

        public void ExibirDetalhesMoto()
        {
            ExibirDetalhesMoto(); //Método herdado de veículo
            Console.WriteLine($"Partida Elétrica: {TemPartidaEletrica}");
        }
    }
}