namespace funcoes;

class Program
{
    static void Main(string[] args)
    {
        
    /*
     tipoDeRetorno NomeDaFuncao(parametros)

    */

    //sem parâmetros e sem retorno 

    //  static void MostrarMensagem()
    //  {
    //     Console.WriteLine("Olá! Boa tarde");
    //  }
    //     //chamando a função
    //     MostrarMensagem();
    
    //  FUNÇÃO COM PARÂMETROS 
        // parâmetro -> string nome 
        // static void Saudacao(string nome)
        // {
        //     Console.WriteLine($"Olá, {nome}!");
        // }
        // Saudacao("joão");

        //FUNÇÃO COM RETORNO
        //parametros a e b
        // retorno é a soma
        // static int Somar(int a, int b)
        // {
        //     // int soma a + b;
        //     return a + b;
        // }
        //     int resultado = Somar(10, 2);
        //     Console.WriteLine(resultado);
        // static void ExibirDobro(int num)
        // {
        //     Console.WriteLine(num * 2);

        // }
        //     ExibirDobro(10);

        //ARRAYS -> armazena vários valores do mesmo tipo em uma única varíavel
        // int[] numeros = new int[5];

        //  Console.WriteLine(numeros);

        // numeros[0] = 2;
        // numeros[1] = 5;
        // numeros[2] = 8;
        // numeros[3] = 15;
        // numeros[4] = 20;

        // Console.WriteLine(numeros);
        
        // Console.WriteLine(string.Join(", ", numeros));

        //EXEMPLO 2 ARRAY
        //Percorrendo com foreach
        // string[] nomes = {"Penelope", "Juan", "Davi"};

        // for (int i = 0; i < nomes.Length; i++)
        // {
        //     Console.WriteLine(nomes[i]);
        // }

        //Percorrendo com foreach
        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        //FUNÇÃO + ARRAY
        // static double CalcularMedia(double[] notas)
        // {

        //     double soma = 0;
        //     for(int i = 0; i < notas.Length; i++)
        //     {
        //         soma += notas[i];
        //         //soma = soma
        //     }
        //     return soma / notas.Length;
        // }

        //     double[] notasAluno = {8.0, 7.5, 9.0,6.5};
        //     double media = CalcularMedia(notasAluno);

        //     Console.WriteLine($"Média final:  {media}");

        //EXEMPLO 2
        // int[] numeros = new int[5];
        // int soma = 0;
        // for(int i = 0; i < numeros.Length; i++)
        // {
        //     Console.WriteLine($"Digite o {i+1}° número: ");
        //     numeros[i] = int.Parse(Console.ReadLine());
        //     soma += numeros[i];
        // }
        //     Console.WriteLine(string.Join(", ", numeros));
        //     Console.WriteLine($"A soma dos números é: {soma}");

        //EXERCICIO 1
        // string [] alunos = {"João", "Maria", "Marcos"};

        // for(int i = 0; i < alunos.Length; i++)
        // {
        //     Console.WriteLine(alunos[i]);

        // }
        //     double [] notas = {8.0, 6.0, 7.0};
        //     for(int i = 0; i < notas.Length; i++)
        //     {
        //         Console.WriteLine($"Nota: {notas}");
        //     }


        // RESULTADO DO EXERCÍCIO
        static string VerificarSituacao(double nota)
        {
            if(nota >= 7)
            return "Aprovado";
        }

        else
        {
            return"Reprovado";
        }

        string[] = new string[3];
        double [] = new double[3];
        for( int i = 0; i < notas.Length; i++)
        {
            Console.Write("Digite o nome do aluno");
            alunos[i] = Console.ReadLine();

            Console.WriteLine("Digite a nota: ");
            notas[i] = double.Parse(Console.ReadLine());
            
        }
        for(int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Aluno{alunos[i]} - Nota: {notas[i]} - Situação: {VerificarSituacao(notas[i])}");
        }
            

            

        



        
 }
}
