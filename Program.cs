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
      // OPERADORES DE ATRIBUIÇÃO:
      // utilizamos igual para atribuir um valor
      // porém, podemos utilizar igual junto a um operador aritmético
      // x += 5 é o mesmo que x = x + 5

      int x = 0;
      x += 5;
      x -= 1;
      x *= 10;
      x /= 2;


      Console.WriteLine(x); // x = 20
    }
  }
}