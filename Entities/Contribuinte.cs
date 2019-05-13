using System.Globalization;
namespace ConsoleLeaozinho.Entities
{
    abstract class Contribuinte
    {
        public string Nome { get; protected set; }
        public double RendaAnual { get; protected set; }

        public Contribuinte(string nome, double renda)
        {
            Nome = nome;
            RendaAnual = renda;
        }

        public abstract double CalculaImposto();

        public override string ToString()
        {
            return Nome + ": $ " + CalculaImposto().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
