using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double capital;
            double taxa;
            double resultTaxa;
            double tempo;
            double juros;
            double montante;

            Console.Write("Digite um Valor R$: ");
            capital = double.Parse(Console.ReadLine());

            Console.Write("Digite a Taxa de Juros %: ");
            taxa = double.Parse(Console.ReadLine());

            Console.Write("Digite o Tempo de Parcelas: ");
            tempo = double.Parse(Console.ReadLine());
            Console.Write("\n");

            resultTaxa = taxa / 100;
            juros = capital * resultTaxa * tempo;
            Console.WriteLine("Seus Juros é = {0}", juros);

            montante = capital + juros;
            Console.WriteLine("Seu Montante é = {0}", montante);
            Console.Write("\n");

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
