namespace atv2SistemasDeFuncionarios;

class Program
{
    static void Main(string[] args)
    {
     Vendedor obj1 = new Vendedor(); //<- Cria o objeto do tipo da classe chamada. EX: [classe].obj1[objeto] = new Vendedor()[instancia objeto = criação do objeto].
     obj1.Nome = "Penelope"; //<-  Dando valor aos atributos.
     obj1.SalarioBase = 2000;

     Gerente obj2 = new Gerente(); 
     obj2.Nome = "Ana";
     obj2.SalarioBase = 3500;

        obj1.ExibirResumo(); //<- Exibe informação herdada da classe pai(superclasse).
        Console.WriteLine("*************************************");
        obj2.ExibirResumo();
    }
}
