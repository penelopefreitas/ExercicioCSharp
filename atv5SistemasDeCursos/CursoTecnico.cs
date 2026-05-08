using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv5SistemasDeCursos
{
    public class CursoTecnico : Curso
    {   
        public CursoTecnico(string NomeConstrutor, int HorasConstrutor) : base(NomeConstrutor, HorasConstrutor) //<- : base = henraça do construtor da classe pai.
        {

        }
        public override double CalcularPreco() 
        {
            return  Horas * 20; //<- valor por horas.
        }
        
            
        
    }
}