using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            double valorNota = 1100;
            double valorImposto = 0;

            bool condicao1 = (valorNota < 1000);
            bool condicao2 = (valorNota >= 1000 && valorNota < 3000);
            bool condicao3 = (valorNota >= 3000 && valorNota < 7000);
            bool condicao4 = (valorNota >= 7000);

            if (condicao1 == true)
            {
                valorImposto = valorNota * 0.02;
            }
            else if (condicao2 == true)
            {
                valorImposto = valorNota * 0.025;
            }
            else if (condicao3 == true)
            {
                valorImposto = valorNota * 0.028;
            }
            else if (condicao4 == true)
            {
                valorImposto = valorNota * 0.03;
            }

            Console.WriteLine("O valor do imposto cobrado é de R$ " + valorImposto);
            Console.WriteLine("Pressione qualquer tecla para fechar!");
            Console.ReadKey();
        }
    }
}
