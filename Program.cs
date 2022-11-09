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
      // CONVERTENDO TIPOS:
      int inteiro = 100;
      float real = 25.4f;

      // inteiro = real; - apresenta erro
      // real = inteiro; - aqui funciona e fica 100.0f
      // para funcionar seria:
      inteiro = (int)real;
    }
  }
}