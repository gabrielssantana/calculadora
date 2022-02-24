namespace src
{
  public class Calculadora
    {
        private double _profundidade;
        private double _comprimento;
        private double _altura;
        private double _rendimento;
        private double _litrosTinta;
        public Calculadora(double profundidade, double comprimento, double altura, double rendimento)
        {
          _profundidade = profundidade;
          _comprimento = comprimento;
          _altura = altura;
          _rendimento = rendimento;
        }
        public double GetLitrosTinta()
        {
          double areaTeto = _profundidade * _comprimento;
          double areaParedes = 2 * (_comprimento + _profundidade) * _altura;
          double areaTotal = areaTeto + areaParedes;
          _litrosTinta = areaTotal / _rendimento;
          return (_litrosTinta);
        }
    }
}