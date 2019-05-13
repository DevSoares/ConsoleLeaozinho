namespace ConsoleLeaozinho.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastoSaude { get; protected set; }

        public PessoaFisica(string nome, double renda, double gasto) : base(nome, renda)
        {
            GastoSaude = gasto;
        }
        public override double CalculaImposto()
        {
            double imposto;
            if (RendaAnual < 20000)
            {
                imposto = RendaAnual * 0.15f - GastoSaude * 0.5;
            }
            else
            {
                imposto = RendaAnual * 0.25f - GastoSaude * 0.5;
            }

            return imposto;
        }
    }
}
