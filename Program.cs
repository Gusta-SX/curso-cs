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
      // CONVERSÃO EXPLÍCITA:
      // ocorre quando os tipos não são compatíveis

      // é dada pelo uso do tipo entre parênteses antes da atribuição:
      int valor = 25;
      uint outro = (uint)valor;
    }
  }
}