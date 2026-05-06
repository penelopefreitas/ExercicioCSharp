

using System.Diagnostics.Contracts;

namespace ProjetLanchonete
{
    public class Bebida : Produto
    {
      public override decimal CalcularPrecoFinal()
      {
         return PrecoBase;
      }
    }
}