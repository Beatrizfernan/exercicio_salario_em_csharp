using System;
using System.Globalization;

namespace exercicio_4_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do Funcionário");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas trabalhadas");
            int horas = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o valor que recebe por hora");
            double valor = double.Parse(Console.ReadLine());


            double salario = valor * horas;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
