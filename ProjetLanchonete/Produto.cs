using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetLanchonete
{
    public abstract class Produto
    {
        
    
        
        public string Nome{get; set;}
        public decimal PrecoBase{get;  set;}

        //NÃO tem corpo, por isso é vazio (não tem "{}") <--
        public abstract decimal CalcularPrecoFinal();
        

        public  void ExibirResumo()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço Final: ");

            
        }

    }

    
}