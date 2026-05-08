namespace atv2SistemasDeFuncionarios;

class Program
{
    static void Main(string[] args)
    {
     List<Funcionario> variavel1 = new List<Funcionario>() //<- Cria uma lista do tipo(classe)Funcionario com o nome da variável(variavel1), instanciando lista(classe).
     {
         new Vendedor("Penelope", 2500), //<- Cria o objeto da classe VENDEDOR para receber os valores.
         new Gerente ("Ana", 4000)
     };
        foreach(Funcionario funcionarios in variavel1)//<- No foreach - Tipo(classe) NomeDaVariavel(funcionarios) - criada para o foreach - IN Lista de nome variavel1.
        {
            funcionarios.ExibirResumo(); /*Variavel do foreach(funcionarios) chamando o método ExibirResumo da classe pai para mostrar os dados
                                            do método sobrescrito (CalcularSalario()) e dos atributos herdados nas classes filhas. 
                                            OBS: Mostrará os dados dependendo do objeto chamado de cada classe(Vendedor ou Gerente).
                                        */
        } 
    }
}
