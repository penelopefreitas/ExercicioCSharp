namespace ExercicioCSharp;

class Program
{
    static void Main(string[] args)
    {
        //CONDICIONAL IF
        // int numero = 10;
        // if(numero > 0)
        // {
        //     Console.WriteLine("Número positivo");
        // }
        //     Console.WriteLine("Número negativo");

        // Console.Write("Digite um número: ");
        // int numero = int.Parse(Console.ReadLine());

        // if (numero > 0)
        // {
        //     Console.WriteLine("Positivo");
        // }

        // else if(numero == 0)
        // {
        //     Console.WriteLine("O número é zero");
        // }
        // else 
        // {
        //     Console.WriteLine("Negativo");
        // }

        // Console.Write("Digite sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // if(idade < 16)
        // {
        //     Console.WriteLine("Não pode votar");
        // }
        // else if (idade < 18)
        // {
        //     Console.WriteLine("Voto opcional");
        // }
        // else 
        // {
        //     Console.WriteLine("Voto obrigatório");
        // }
        

        // NOTA DO ALUNO******
        // Console.Write("Digite a nota: ");
        // double nota = double.Parse(Console.ReadLine());

        // if (nota >= 7)
        // {
        //     Console.WriteLine("Aprovado!");
        //     if(nota >= 9)
        //     {
        //         Console.WriteLine("Aprovado e ganhou estrelinha!");
        //     }
        // }
        // else if(nota >= 5)
        // {
        //     Console.WriteLine("Recuperação");

        // }
        // else 
        // {
        //     Console.WriteLine("Reprovado");
        // }
        
        // int n1 = 25;
        // int n2 = 30;

        // if(n1 > n2)
        // {
        //     Console.WriteLine("Primeiro n1 é maior");
        // }
        // else if (n2 > n1)
        // {
        //     Console.WriteLine("Segundo n2 é maior");
        // }
        // else
        // {
        //     Console.WriteLine("Números são iguais");
        //USUARIO E SENHA CONDICIONAL*********
        // }
        // Console.Write("Usuário: ");
        // string usuario = Console.ReadLine();
        
        // Console.Write("Senha: ");
        // string senha = Console.ReadLine();

        // if(usuario == "admin" && senha == "1234")
        // {
        //     Console.WriteLine("Acesso permitido. ");
        // }

        // else 
        // {
        //     Console.WriteLine("Acesso negado. ");
        // }
            // Console.Write("Digite um número: ");
            // int numero = int.Parse(Console.ReadLine());


            // //IF TERNARIO**********
            // string resultado = numero % 2 == 0 ? "Par" : "Ímpar";
            // Console.WriteLine(resultado);

            // if(numero % 2 == 0)
            // {
            //     Console.WriteLine("Par");
            // }
            // else
            // {
            //     Console.WriteLine("Ímpar");
            // }
            // int idade = 18;
            // Console.WriteLine(idade >= 18 ? "Maior de idade" : "Menor de idade");


            //Switch Case*********
            // Console.Write("Digite um número de 1 a 3: ");
            // int opcao = int.Parse(Console.ReadLine());

            // switch (opcao)
            // {
            //     case 1:
            //     Console.WriteLine("Você escolheu a opção 1");
            //     break;
            
                
            //     case 2:
            //     Console.WriteLine("Você escolheu a opção 2.");
            //     break;

            //     case 3:
            //     Console.WriteLine("Você escolheu a opção 3.");
            //     break;

            // default:
            //     Console.WriteLine("Opção Inválida");
            //     break;
            // }
            
            // Console.Write("Digite uma opção A, B OU C: ");
            // string escolha = Console.ReadLine().ToUpper();

            // switch(escolha)
            // {
            //     case "A":
            //     Console.WriteLine("Você escolheu a opção A");
            //     break;

            //     case "B":
            //     Console.WriteLine("Você escolheu a opção B");
            //     break;

            //     case "C":
            //     Console.WriteLine("Você escolheu a opção C");
            //     break;

            //     default:
            //     Console.WriteLine("Opção Inválida");
            //     break;



            //EXERCICIOS 
            //NIVEL FACIL
            //NUMERO MAIOR QUE 100 - ATIVIDADE 1

            // Console.Write("Digite um número: ");
            // int n1 = int.Parse(Console.ReadLine());
            
            // if(n1 >= 100)
            // {
            //     Console.WriteLine("Número igual ou acima de 100.");
            // }
            // else 
            // {
                
            //     Console.WriteLine("Número abaixo de 100");
            // }

            // SENHA SIMPLES - ATIVIDADE 2
            // Console.Write("Digite uma senha: ");
            // string senha = Console.ReadLine();

            // if (senha == "admin123")
            // {
            //     Console.WriteLine("Senha correta!");
            // }
            // else
            // {
            //     Console.WriteLine("Senha incorreta");
            // }

            // //EXERCICIO 3 (FALTA TERMINAR)
            // Console.WriteLine("Digite um número: ");
            // int digito = int.Parse(Console.ReadLine());

            // if(digito == )
            // {
            //     Console.WriteLine("Número positivo");
            // }
            // else
            // {
            //     Console.WriteLine("Número inválido");
            // }

            //TERNÁRIO POSITIVO OU NEGATIVO - ATIVIDADE 4
            // Console.Write("Para se cadastrar, digite sua idade: ");
            // int idade = int.Parse(Console.ReadLine());
           

            // Console.WriteLine(idade >= 16 ? "Cadastrado Permitido." : "Cadastro Negado.");

            //SWITCH - ATIVIDADE 5
            // Console.Write("Digite um período (1- manhã, 2- tarde, 3- noite): ");
            // int periodo = int.Parse(Console.ReadLine());
            
            // switch (periodo)
            // {
            //     case 1:
            //     Console.WriteLine("Manhã");
            //     break;

            //     case 2:
            //     Console.WriteLine("Tarde");
            //     break;

            //     case 3:
            //     Console.WriteLine("Noite");
            //     break;

            //     default:
            //     Console.WriteLine("Opção Inválida");
            //     break;

            //  Console.Write("Digite uma opção (1- Novo jogo, 2- Carregar jogo, 3- Sair): ");
            // int jogo = int.Parse(Console.ReadLine());
            
            // switch (jogo)
            // {
            //     case 1:
            //     Console.WriteLine("Novo jogo");
            //     break;

            //     case 2:
            //     Console.WriteLine("Carregar jogo");
            //     break;

            //     case 3:
            //     Console.WriteLine("Sair");
            //     break;

            //     default:
            //     Console.WriteLine("Opção Inválida. Tente novamente.");
            //     break;
            // }
                
                // CLASSIFICACAO DE IDADE - ATIVIDADE 6
            // Console.Write("Digite sua idade: ");
            // int idade = int.Parse(Console.ReadLine());

            // if(idade >= 18)
            // {
            //     Console.WriteLine("Adulto");
            // }
            // else if(idade >= 13)
            // {
            //     Console.WriteLine("Adolescente");
            // }
            // else{
            //     Console.WriteLine("Criança");
            // }

            //MAIOR ENTRA DOIS TERNÁRIOS - ATIVIDADE 7
            // int n1 = 18;
            // int n2 = 12;
            // string resultado = n1 > n2 ? "n1 é maior que n2" : "n2 é maior que n1";

            // Console.WriteLine(resultado);

            //ACESSO COM DUAS CONDIÇÕES - ATIVIDADE 8 
            // Console.Write("Informe sua idade: ");
            // int idade = int.Parse(Console.ReadLine());

            // Console.WriteLine("Possui ingresso?");
            // string ingresso = Console.ReadLine().ToUpper();



        // if(idade >= 18 || ingresso == "Sim")
        // {
        //     Console.WriteLine("Entrada autorizada.");
        // }
        //     else{
        //         Console.WriteLine("Entrada negada.");
        //     }
            
        //     if(idade >= 18)
        //     {
        //         Console.WriteLine("Entrada autorizada.");

        //     }
        //     else
        //     {
        //         Console.WriteLine("Entrada negada.");
        //     }


            //NUMERO DENTRO DA FAIXA - ATIVIDADE 9 FALTA TERMINAR ***
        //    Console.WriteLine("Digite um número: ");

            //DESCONTO POR IDADE - ATIVIDADE 10
            // Console.WriteLine("Digite sua idade: ");
            // int idade = 5;
            
            // if(idade >= 18 && idade <= 59)
            // {
            //     Console.WriteLine("Desconto de 10%");
            // }
            // else if (idade < 18)
            // {
            //     Console.WriteLine("Sem desconto");
            // }
            // else
            // {
            //     Console.WriteLine("Desconto de 20%");
            // }


            // ATIVIDADE 10
            // decimal valor = 850m;
            // decimal final = valor >= 200 ? valor * 0.85m : valor * 0.95m;
            
            // Console.WriteLine(final);
        
            //CALCULADORA SWITCH - ATIVIDADE 11
            // Console.Write("Digite o primeiro valor: ");
            // double a = double.Parse(Console.ReadLine());

            // Console.Write("Digite o segundo valor: ");
            // double b = double.Parse(Console.ReadLine());

            // Console.Write("Digite a operaçã desejada (+, -, * ou /)");
            // string op = Console.ReadLine();

            // switch(op)
            // {
            //     case "+":
            //     Console.WriteLine("Resultado: " + (a + b));
            //     break;

            //     case "-":
            //     Console.WriteLine("Resultado: " + (a - b));
            //     break;

            //     case"/":
            //     Console.WriteLine("Resultado: " + (a/b));
            //     break;

            //     case  "*":
            //     Console.WriteLine("Resultado: " = (a*b));
            //     break;

            //     default:
            //     Console.WriteLine("Opção Inválida");
            //     break;
            // }

            // DIA ÚTIL OU FIM DE SEMANA - ATIVIDADE 12
            // Console.Write("Digite o dia: ");
            // int dia = int.Parse(Console.ReadLine());

            // switch(dia)
            // {
            //     case 1:
            //     case 7:
            //         Console.WriteLine("Fim de semana");
            //         break;
            //     case 2:
            //     case 3:
            //     case 4:
            //     case 5:
            //     case 6:
            //         Console.WriteLine("Dia útil");
            //     break;

            //     default:
            //         Console.WriteLine("Dia inválido");
            //         break;
            // }

            //PLANO DE INTERNET - ATIVIDADE 13
            // Console.Write("Digite o plano (Básico | Intermediário | Premium): ");
            // string plano = Console.ReadLine().ToLower();
            // //ToLower() -> deixa o texto em minúsculo

            // switch(plano)
            // {
            //     case "básico":
            //      Console.WriteLine("10MB");
            //      break;
                
            //     case "Intermediário":
            //         Console.WriteLine("50MB");
            //     break;

            //     case "Premium":
            //     Console.WriteLine("100MB");
            //     break;

            //     default:
            //         Console.WriteLine("Plano inválido");
            //     break;
            // }

            //SISTEMA DE NOTAS COMPLETO - ATIVIDADE 14
            // double nota = 5.0;
            // if(nota < 0 || nota > 10)
            // {
            //     Console.WriteLine("Nota inválida");
            // }
            // else if (nota >= 7)
            // {
            //     Console.WriteLine("Aprovado");
            // }
            // else if(nota >= 5)
            // {
            //     Console.WriteLine("Recuperação");
            // }
            // else{
            //     Console.WriteLine("Reprovado");
            // }

            //TRIANGULO - ATIVIDADE 15
                // int a = 10;
                // int b = 5;
                // int c = 3;

                // if(a > 0 && b > 0 && c > 0 )
                // {
                //     Console.WriteLine("Pode formar um triângulo");
                // }
                // else
                // {
                //     Console.WriteLine("Inválido");
                // }
            
            //CALCULADORA SIMPLES - ATIVIDADE 16
            //  Console.Write("Digite o primeiro valor: ");
            // double a = double.Parse(Console.ReadLine());

            //     Console.Write("Digite o segundo valor: ");
            // double b = double.Parse(Console.ReadLine());

            //     Console.Write("Digite a operaçã desejada (+, -, * ou /)");
            // string op = Console.ReadLine();

            // if(op == "+")
            // {
            //     Console.WriteLine("Resultado: " + (a+b));
            // }
            // else if(op == "-")
            // {
            //     Console.WriteLine("Resultado: " + (a-b));
            // }
            // else if(op == "*")
            // {
            //     Console.WriteLine("Resultado: " + (a*b));
            // }
            // else
            // {
            //     Console.WriteLine("Resultado: " + (a/b));
            // }

            //LOGIN COM TENTATIVAS - ATIVIDADE 17
            // string usuario = "penelope";
            // string senha = "1234";

            // if(usuario == "admin" && senha == "1234")
            // {
            //     Console.WriteLine("Acesso Liberado.");
            // }

            // else
            // {
            //     Console.WriteLine("Acesso Negado.");
            // }
            // TERNARIO ENCADEADO - ATIVIDADE 18
            // int numero = 5;

            // string resultado = numero > 0 ? "Positivo" : numero == 0 ? "Zero" : "Negativo";
            // Console.WriteLine(resultado);

            //MENU DE OPERAÇÕES COMPLETO - ATIVIDADE 19
            //  switch(op)
            // {
            //     case "+":
            //     Console.WriteLine("Resultado: " + (a + b));
            //     break;

            //     case "-":
            //     Console.WriteLine("Resultado: " + (a - b));
            //     break;

            //     case"/":
            //     if(a == 0 || bool == 0 )
            //     {
            //         Console.WriteLine("")
            //     }
            //     Console.WriteLine("Resultado: " + (a/b));
            //     break;

            //     case  "*":
            //     Console.WriteLine("Resultado: " = (a*b));
            //     break;

            //     default:
            //     Console.WriteLine("Opção Inválida");
            //     break;
            // }
            //ATIVIDADE 20
            // Console.Write("Digite uma opção(1- água | 2 - refrigerante | 3 - suco): ");
            // int opcao = int.Parse(Console.ReadLine());

            // switch (opcao)
            // {
            //     case 1:
            //     Console.WriteLine("Água - R$2");
            //     break;

            //     case 2:
            //     Console.WriteLine("Refrigenta - R$5");
            //     break;

            //     case 3:
            //     Console.WriteLine("Suco - R$4");
            //     break;
            // }

            
 


            

             



    


            

                
            
            

            
                
            
            
                
    }
}
