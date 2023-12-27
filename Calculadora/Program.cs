using System;
using System.Globalization;
using Application;
using Application.Models;
using Data;
using Data.Arquivo;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = Operacoes.Somar(v1, v2);

            SalvarHistoricoOperacoes("Soma", resultado);

            Console.WriteLine("O resultado da soma é " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = Operacoes.Subtrair(v1, v2);

            SalvarHistoricoOperacoes("Subtração", resultado);

            Console.WriteLine("O resultado da subtração é " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = Operacoes.Dividir(v1, v2);

            SalvarHistoricoOperacoes("Divisão", resultado);

            Console.WriteLine("O resultado da divisão é " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = Operacoes.Multiplicar(v1, v2);

            SalvarHistoricoOperacoes("Multiplicação", resultado);

            Console.WriteLine("O resultado da multiplicação é " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
            Menu();
        }

        static void SalvarHistoricoOperacoes(string operacao, float resultado)
        {
            var historico = new OperacoesHistorico(operacao, resultado, DateTime.Now);
            using (var repo = new OperacoesHistoricoDAO())
                repo.Adicionar(historico);

            var salvarArquivo = new SalvarArquivo();
            salvarArquivo.Salvar(operacao);
        }
    }
}
