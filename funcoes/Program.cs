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
        // static string VerificarSituacao(double nota)
        // {
        //     if(nota >= 7)
        //     return "Aprovado";
        

        // else
        // {
        //     return"Reprovado";
        // }

        // string[] = new string[3];
        // double [] = new double[3];
        // for( int i = 0; i < notas.Length; i++)
        // {
        //     Console.Write("Digite o nome do aluno");
        //     alunos[i] = Console.ReadLine();

        //     Console.WriteLine("Digite a nota: ");
        //     notas[i] = double.Parse(Console.ReadLine());
            
        // }
        // for(int i = 0; i < alunos.Length; i++)
        // {
        //     Console.WriteLine($"Aluno{alunos[i]} - Nota: {notas[i]} - Situação: {VerificarSituacao(notas[i])}");
        // }
            //ARREDONDAMENTO
        //  double numero = Math.Round(3.6);
        //  Console.WriteLine(numero);
        // RANDOM ( para gerar números aleatórios)
        // Random random = new Random(); //cria o gerador de números automáticos.
        // int numero = random.Next(1, 101); // gera os números entre 1 e 100.
        // // int numero = rando.Next(101); // gera os números começando em 0.

        // Console.WriteLine(numero);
        
        //Funções para strings(textos)

        //tamanho da string
        // string texto = "CSharp";
        // int tamanho = texto.Length;

        // Console.WriteLine(tamanho);

        // string frase = "Olá, mundo";
        // frase = frase.Replace("mundo","CSharp");
        // Console.WriteLine(frase);

        // string frase = "Estou aprendendo CSharp.";

        // if(frase.Contains("CSharp"))
        // {
        //     Console.WriteLine("A Contém 'CSharp'. ");
        // }
        
        // bool existe = frase.Contains("CSharp");
        // Console.WriteLine(existe);

        //funções dentro de arrays
        // int[] numeros = {1, 2, 4, 12, 8};
        //  Array.Sort(numeros); // ordena os valores
        // Console.WriteLine(string.Join(", ", numeros));

        // //inverter valores 
        // Array.Reverse(numeros);
        // Console.WriteLine(string.Join(", ", numeros));

        //Simular adicionar valores em array
        // string[] nomes = {"Ana", "Bruno", "Carlos"};
        // string novoNome = "Pedro";

        // string[] novoArray = new string[nomes.Length + 1];

        // for(int i = 0; i < nomes.Length; i++)
        // {
        //     novoArray[i] = nomes[i];
        // }
        //     novoArray[novoArray.Length - 1] = novoNome;
        //     nomes = novoArray;
        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }
        //*********************************************

        //Adicionando elementos com LIST
        // List<string> nomes = new List<string>();
        //Adicionando nomes da lista
        // nomes.Add("Ana");
        // nomes.Add("Bruno");
        // nomes.Add("Carlos");
        // nomes.Add("Pedro");

        //Removendo nomes da lista
        // nomes.Remove("Bruno");

        // foreach (string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }
        // // acessar pela posição(indice)
        // Console.WriteLine(nomes[0]);

        //Tamanho da lista
        // Console.WriteLine(nomes.Count);

        //Realizando busca dentro da Lista
        // Console.Write("Digite o nome na busca: ");
        // string nomeDigitado = Console.ReadLine();
        // if(nomes.Contains("Ana"))
        // {
        //     Console.WriteLine("Nome encontrado!");
        // }

        // Inserindo nome em posição específica
        // nomes.Insert(2, "Paula");

        //Removendo nomes na posição
        // nomes.RemoveAt(3);
        //Limpando a lista
        // nomes.Clear();

        // foreach (string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }

        //Sisteminha: Removendo item digitado
        // List<string> produtos = new List<string>();
        // produtos.Add("Mouse");
        // produtos.Add("Teclado");
        // produtos.Add("Monitor");

        // Console.Write("Digite o produto para removê-lo: ");
        // string remover = Console.ReadLine();

        // if(produtos.Contains(remover))
        // {
        //     // vai remover o produto
        //     produtos.Remove(remover);
        //      foreach (string produto in produtos)
        // {
        //     Console.WriteLine(produto);
        // }

        // }

        // else{
        //     Console.WriteLine("Produto inexistente.");
        // }

        //Criando menu com LIST
        // List<string> opcoes = new List<string>();
        // opcoes.Add("1- Adicionar tarefa");
        // opcoes.Add("2- Listar tarefas");
        // opcoes.Add("3- Remover tarefa");
        // opcoes.Add("0- Sair");

        // Console.WriteLine(opcoes);
        

        // Console.WriteLine("Digite uma das opções: ");
        // int digite = int.Parse(Console.ReadLine());


        // switch(digite)
        //     {case 1:
        //     Console.WriteLine("Tarefa adicionada.");
        //     break;

        //     case 2:
        //     Console.WriteLine("tarefa listada.");
        //     break;

        //     case 3:
        //     Console.WriteLine("Tarefa removida.");
        //     break;

        //     case 0:
        //     Console.WriteLine("Você saiu do menu.");
        //     break;
        //     }

        // List<string> tarefas = new List<string>();

        // int opcao;
        // do
        // {
        //     Console.WriteLine("Bem-vindo(a) ao menu de sistema de tarefas!");
        //     Console.WriteLine("1- Adicionar tarefa");
        //     Console.WriteLine("2- Listar tarefa");
        //     Console.WriteLine("3- Remover tarefa"); 
        //     Console.WriteLine("0- Sair");

        //     opcao = int.Parse(Console.ReadLine());
            
        //     switch(opcao)
        //     {
        //         case 1:
        //         Console.WriteLine("Digite a tarefa: ");
        //         tarefas.Add(Console.ReadLine());
        //         break;

        //         case 2:
        //         foreach(string tarefa in tarefas)
        //         {    Console.WriteLine("Tarefas: ");
        //             Console.WriteLine(tarefa);
        //         }   break;

        //         case 3:
        //         Console.WriteLine("Digite a tarefa para removê-la: ");
        //         tarefas.Remove(Console.ReadLine());
        //         break;

        //         case 0:
        //         Console.WriteLine("Saindo...");
        //         Console.WriteLine("Sistema encerrado.");
        //         break;

        //         default:
        //         Console.WriteLine("Opção inválida.");
        //         break;

        //     }

        // }while(opcao!= 0);

        //ATIVIDADE 1 - ARRAYS E FUNÇÕES


        //ARRAYS E FUNÇÕES - ATIVIDADE 2 
        // string[] nomes = {"Ana", "Carlos", "Bruno", "Duda"};
        // Array.Reverse(nomes);
        // for(int i = 0; i < nomes.Length; i++)
        // {
        //     Console.WriteLine(nomes[i]);
        // }
        
        //ARRAYS E FUNÇÕES - ATIVIDADE 3
        string palavra = "Oi";
        int[] numero = {3};
        
        while(string palavra2 in palavra)
        {
            Console.WriteLine(palavra);
        }




    

        
        
       


        


        


        
        










        



        
 }
}
