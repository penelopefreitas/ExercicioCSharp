using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetLanchonete
{
    public class Produto
    {
        public abstract class Produto
    {
        
        public string nome{get; set;}
        public decimal precoBase{get; private set;}


        public abstract void CalcularPrecoFinal();

        public  void ExibirResumo(){
            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Preço Final: ");

            
        }
    }
}