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
      // ESTRUTURA CONDICIONAL: IF
      int idade = 12;
      int maioridade = 18;
      
      // estrutura sem chaves
      if (idade >= maioridade)
        Console.WriteLine("é maior de idade");
      else
        Console.WriteLine("é menor de idade");
     }
  }
}