using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntrega1604
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valor = 100;
            double total = 0;
            int meio = 0;
            int inteiro = 0;
            for (int ingresso = 1; ingresso <= 30; ingresso++)
            {
                Console.WriteLine("Possui forma de comprovar ser estudante?: S(sim)/N(não)");
                int estudante = int.Parse(Console.ReadLine());
                if (ingresso <= 10 && estudante == 1)
                {
                    valor = valor / 2;
                    meio++;
                }
                else if (ingresso <= 20 && estudante == 1)
                {
                    meio++;
                    valor = (valor * 1.5) / 2;
                }
                else if (ingresso <= 30 && estudante == 1)
                {
                    meio++;
                    valor = (valor * 3) / 2;
                }
                if (ingresso <= 10 && estudante == 2)
                {
                    inteiro++;
                    valor = valor;
                }
                total += valor;
            }
            Console.WriteLine("A quantidade de ingressos inteiros é de" + inteiro);
            Console.WriteLine("O total foi de:" + total);
            Console.WriteLine("A quantidade de ingressos que pagaram meia é:" + meio);
        }
    }
}