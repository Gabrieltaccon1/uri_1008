using System;

namespace URI_1008
{
    class Program
    {
        static void Main(string[] args)
        {

            int registroFuncionario, horasTrabalhadas;
            double salario, salarioHora;

            Console.WriteLine("Digite o numero de resgistro do funcionario");
            registroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas trabalhadas");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor pago por hora para este funcionario");
            salarioHora = double.Parse(Console.ReadLine());

            salario = horasTrabalhadas * salarioHora;

            Console.Write("O NUMERO DE RESGISTRO DO FUNCIONARIO É: " + registroFuncionario);
            Console.ReadLine();

            Console.Write("O SALARIO TOTAL É DE: " + salario);
            Console.ReadLine();

        }
    }
}
