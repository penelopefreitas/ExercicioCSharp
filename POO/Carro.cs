

namespace POO
{   // subclasse = herda informações da classe veículo.
    public class Carro : Veiculo
    {
        //atributos da classe
         public string Marca;
         public string Modelo;
         public int Ano;

         //Métodos (ações que a classe poderá realizar)
         public void ExibirInformacoes()
         {
            Console.WriteLine($"Carro: {Marca}, {Modelo}, Ano: {Ano}");
         }


    }
}