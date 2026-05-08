

namespace POO_ATV_ProfGuilherme
{   
    public abstract class Veiculo // <- Criação de uma superclasse(pai) abstrata. Classes pai abstratas NÃO podem criar objetos diretamente dela.
    {   public string Modelo; // <- Atributo público do tipo texto para modelo do veículo.
        public int Ano; //<- Atributo público do tipo numérico para ano do veículo.

        public Veiculo(string ModeloDoConstrutor, int AnoDoConstrutor) //<- OBS: O nome do construtor deve ser o mesmo da classe. O construtor serve para preencher as variáveis vazias(Ex: public string Modelo; encontra-se sem valor)
        {
            Modelo = ModeloDoConstrutor; // <- A Variável (Modelo) recebe o valor do construtor (ModeloDoConstrutor).
            Ano = AnoDoConstrutor;  // <- A Variável (Ano) recebe o valor do construtor (AnoDoConstrutor).
            } 
        public abstract double CalcularRevisao(); //<- Método abstrato (termina com ";").
        public virtual void ExibirResumo() // <- Exibe resumo do modelo, ano e valor da revisão. É um método comum e não abstrato, por isso precisa ter corpo.
        {
           Console.WriteLine($"Modelo: {Modelo}, Ano: {Ano}"); //<- Texto que mostrará Modelo e ano no Program.
           Console.WriteLine($"Valor da revisão: {CalcularRevisao():C}\n"); // <- Chama o método abstrato CalcularRevisao para mostrar valor das classes filhas.
                                                                        //-> \n quebra linha.
            }


}   }