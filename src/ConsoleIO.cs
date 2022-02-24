namespace src
{
  public class ConsoleIO
    {
        public double Read(string message)
        {
          string? number;
          double data;
          Console.WriteLine(message);
          number = Console.ReadLine();
          if (number != null)
            data = double.Parse(number);
          else
            data = -1;
          return data;
        }
    }
}