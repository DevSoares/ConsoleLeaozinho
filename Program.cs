using System;
using System.Collections.Generic;
using ConsoleLeaozinho.Entities;
using System.Globalization;

namespace ConsoleLeaozinho
{
    class Program
    {
        static void Main(string[] args)
        {
            byte trava = 1;
            while (trava != 0)
            {
                List<Contribuinte> contribuintes = new List<Contribuinte>();
                double somaImposto = 0.0f;
                Console.Write("Entre com a quantidade de contribuintes: ");
                int n = int.Parse(Console.ReadLine());

                for(int i = 1; i<=n; i++)
                {
                    Console.WriteLine($"Dados do contribuinte #{i}: ");
                    Console.Write("Pessoa Física ou Jurídica ? (f/j): ");
                    string ch = Console.ReadLine();
                    ch.ToLower();
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda anual: ");
                    double renda = double.Parse(Console.ReadLine());
                    if (ch == "f")
                    {
                        Console.Write("Gastos com saúde: ");
                        double gastos = double.Parse(Console.ReadLine());
                        contribuintes.Add(new PessoaFisica(nome, renda, gastos));
                    }
                    else
                    {
                        Console.Write("Número de funcionários: ");
                        int funcionarios = int.Parse(Console.ReadLine());
                        contribuintes.Add(new PessoaJuridica(nome, renda, funcionarios));
                    }
                }

                Console.WriteLine("\nIMPOSTOS PAGOS:");
                foreach(Contribuinte contribuinte in contribuintes)
                {
                    somaImposto += contribuinte.CalculaImposto();
                    Console.WriteLine(contribuinte);
                }
                Console.WriteLine("\nIMPOSTO TOTAL: $ "+somaImposto.ToString("f2", CultureInfo.InvariantCulture));

                Console.WriteLine("\nType 0 to quit application.");
                trava = byte.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
