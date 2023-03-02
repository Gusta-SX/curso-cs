// importções - definem o que nosso programa irá utilizar
using System;

// namespaces - divisão lógica de classes
namespace Teste
{
  // classe
  class Program
  {
    // metodo principal
    static void Main(string[] args)
    {
      // OPERAÇÕES LÓGICOS
      int x = 12;
      bool entre = (x > 25) && (x < 40); // false
      bool ou = (x > 25) || (x < 40); // true
      bool negacao = !(x > 25); // true

      Console.WriteLine(negacao);
     }
  }
}