using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv5SistemasDeCursos
{
    public abstract class Curso 
    {
        public string Nome { get; set; } = string.Empty; // <- string.Empty = " "(aspas vazia);
        public int Horas { get; set; }

        public Curso(string NomeConstrutor, int HorasConstrutor) // <- Construtor 
        {
            Nome = NomeConstrutor;
            Horas = HorasConstrutor;
        }
        public abstract double CalcularPreco();

        public virtual void ExibirResumo() //<- Toda vez que for polimorfismo precisará colocar anteriormente "virtual".
        {
            Console.WriteLine($"Curso: {Nome}");
            Console.WriteLine($"Carga horário: {Horas}");
            Console.WriteLine($"Preco Final: {CalcularPreco():F2}\n"); //<- \n quebra a linha.
            
            
        }



    }
}