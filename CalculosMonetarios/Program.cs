using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculosMonetarios
{
    internal class Program
    {

        const decimal taxaDiariaMulta = 0.33M;
        static void Main(string[] args)
        {
            DateTime dataVencimento = new DateTime(2023, 1, 24);
            Console.WriteLine("Dias de atraso: " + Convert.ToString(CalcularDiasAtraso(dataVencimento)));
            Console.WriteLine("Percentual de multa: " + Convert.ToString(PercentualMulta(dataVencimento)) + "%");

        }
        private static Decimal PercentualMulta(DateTime dataVencimento)

        {
            int diasAtraso = CalcularDiasAtraso(dataVencimento);
            if (diasAtraso > 60)
                return 20M;
            return diasAtraso * taxaDiariaMulta;
        }
        private static int CalcularDiasAtraso(DateTime dataVencimento)
        {
            DateTime dataAtual = DateTime.Now;
            int diasAtraso = dataAtual.Subtract(dataVencimento).Days;
            if (diasAtraso < 0)
                return 0;

            return diasAtraso;

            
        } 
    }
}
