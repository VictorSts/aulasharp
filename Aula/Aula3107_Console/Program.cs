using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3107_Console
{
    class Program
    {
        public static int num1 { get; set; }

        public static int num2 { get; set; }

        private static int res;

        private static string num;

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número 1:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número 2:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação:");
            num = Console.ReadLine();

            switch (num)
            {
                case "+":
                    {
                        Adicao(num1, num2);
                        break;
                    }

                case "-":
                    {
                        Subtracao(num1, num2);
                        break;
                    }

                case "*":
                    {
                        Multiplicacao(num1, num2);
                        break;
                    }

                case "/":
                    {
                        Divisao(num1, num2);
                        break;
                    }
                default:
                    break;
            }
            Console.ReadKey();
        }
        static void Adicao(int num1, int num2)
        {
            res = num1 + num2;
            Console.WriteLine("Soma é: " + res);
        }

        static void Subtracao(int num1, int num2)
        {
            res = num1 - num2;
            Console.WriteLine("Subtração é: " + res);
        }

        static void Multiplicacao(int num1, int num2)
        {
            res = num1 * num2;
            Console.WriteLine("Multiplicação é: " + res);
        }

        static void Divisao(int num1, int num2)
        {
            res = num1 / num2;
            Console.WriteLine("Divisão é: " + res);
        }
    }
}
