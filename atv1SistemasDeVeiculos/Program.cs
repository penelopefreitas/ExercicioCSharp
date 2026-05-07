namespace POO_ATV_ProfGuilherme;

class Program
{
    static void Main(string[] args)
    {
        Carro obj1 = new Carro(); // <- Classe.objeto = new instância(vazia).
        obj1.Modelo = "Civic";  // <- Cria objeto.Variavel( vinda da classe pai){Modelo}.
        obj1.Ano = 2026;        

        Moto obj2 = new Moto(); // <- O mesmo comentário do obj1.
        obj2.Modelo = " Sahara"; // <- Cria objeto.Variavel( vinda da classe pai){Modelo}.
        obj2.Ano = 2025;        // <- Cria objeto.Variavel( vinda da classe pai){Ano}.
        
        

        obj1.ExibirResumo();
        Console.WriteLine("***************************");
        obj2.ExibirResumo();

    }
}
