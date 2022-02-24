using src;

namespace Program
{
  public class Program
    {
        static void Main()
        {
          List<double> quantidades = new List<double>();
          ConsoleIO console = new ConsoleIO();
          quantidades.Add(console.Read("Qual a profundidade?"));
          quantidades.Add(console.Read("Qual o comprimento?"));
          quantidades.Add(console.Read("Qual a altura?"));
          quantidades.Add(console.Read("Qual o rendimento da tinta?"));
          foreach (double number in quantidades)
            if (number <= 0)
              {
                Console.WriteLine("Você inseriu algum valor zero ou negativo!");
                return;
              }
          Calculadora calc = new Calculadora(quantidades[0], quantidades[1], quantidades[2], quantidades[3]);
          Console.WriteLine($"\nVocê precisará de {calc.GetLitrosTinta()} litros de tinta.\n");
          console.Read("Aperte qualquer tecla para sair!");
        }
    }
}