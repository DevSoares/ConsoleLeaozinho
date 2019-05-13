namespace ConsoleLeaozinho.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int QuantidadeFuncionarios { get; protected set; }

        public PessoaJuridica(string nome, double renda, int funcionarios) : base(nome, renda)
        {
            QuantidadeFuncionarios = funcionarios;
        }

        public override double CalculaImposto()
        {
            double imposto;
            if (QuantidadeFuncionarios > 10)
            {
                imposto = RendaAnual * 0.14;
            }
            else
            {
                imposto = RendaAnual * 0.16;
            }
            return imposto;
        }
    }
}
