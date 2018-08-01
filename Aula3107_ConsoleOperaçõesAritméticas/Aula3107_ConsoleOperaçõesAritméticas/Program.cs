using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3107_ConsoleOperaçõesAritméticas
{
    class Program
    {
        public static int Id { get; set; }

        public static int num1 { get; set; }

        public static int num2 { get; set; }

        public static int soma { get; set; }

        public static int subtracao { get; set; }

        public static int multiplicacao { get; set; }

        public static int divisao { get; set; }

        static void Main(string[] args)
        {
            /**int num1, num2,soma,subtracao,multiplicacao,divisao;
            Console.WriteLine("=================");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
            Console.WriteLine("=================");
            Console.ReadLine();**/

            Console.WriteLine("Digite o numero 1:");
            num1 = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite o numero 2:");
            num2 = int.Parse(Console.ReadLine());    

            //processamente
            soma = num1 + num2;
            subtracao = num1 - num2;
            multiplicacao = num1 * num2;
            divisao = num1 / num2;
            ImprimirNumeroDigitado(Id);

            //Saída
            /**Console.Write("\nSoma: " + soma);
            Console.Write("\nSubtração: " + subtracao);
            Console.Write("\nMultiplicação: " + multiplicacao);
            Console.Write("\nDivisão: " + divisao);
            Console.ReadKey();**/
        }

        static void ImprimirNumeroDigitado(int num)
        {
            //Console.WriteLine("Você digitou: " + num);

            Console.WriteLine("\nSoma: " + soma);
            Console.WriteLine("\nSubtração: " + subtracao);
            Console.WriteLine("\nMultiplicação: " + multiplicacao);
            Console.WriteLine("\nDivisão: " + divisao);
            Console.ReadKey();
        }
    }
}
