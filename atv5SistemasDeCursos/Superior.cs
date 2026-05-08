using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv5SistemasDeCursos
{
    public class Superior : Curso
    {
        public Superior(string NomeConstrutor, int HorasConstrutor) : base(NomeConstrutor, HorasConstrutor) // o nome do construtor precisa ser sempre o mesmo nome da classe. : base herda o construtor da superclasse.
        {

        }
        public override double CalcularPreco()
        {
            return Horas * 40;
        }
    }
}