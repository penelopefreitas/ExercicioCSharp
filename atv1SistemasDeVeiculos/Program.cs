namespace POO_ATV_ProfGuilherme;

class Program
{
    static void Main(string[] args)
    {
        List<Veiculo> variavel1 = new List<Veiculo>() //<- Cria uma lista do tipo Veículo onde armazenará os objetos. OBS: Será do tipo veículo porque ambas as classes, Moto e Carro a herdam.
        {
            new Carro("Civic", 2025), // <- cria um objeto da classe Carro onde o construtor da mesma recebe esses valores.<<
            new Moto("PCX", 2025)     // <- O mesmo do comentário acima.

        };
        //foreach -> dá a primeira volta em objeto Carro e chama o valor Civic 2025.
        foreach(Veiculo veiculos in variavel1) // foreach(Tipo[Veiculo] nomeDaVariavel[veiculos] in list[variavel1])
        {
            veiculos.ExibirResumo(); 
        }

        
        
    
    }
}
