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
      // CONVERSÃO IMPLÍCITA:
      // é comum precisarmos transformar um dado de tipo X para tipo Y
      // as conversões podem ser implicitas e explicitas.

      // as implícitas são conversões que podem ser executadas com passagem de dados e possuimos tipos compativeis:
      float valor = 25.8F;
      int outro = 25;

      valor = outro; // posso colocar um numero int dentro do float, porem nao o contrario

    }
  }
}