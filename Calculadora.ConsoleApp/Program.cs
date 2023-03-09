﻿internal class Program
{
    static void Main(string[] args)
    {

        do
        {
            Console.Clear();

            Console.WriteLine("\r --- Calculadora ---");

            Console.WriteLine();

            Console.WriteLine("\r Digite 1 para Somar");
            Console.WriteLine("\r Digite 2 para Subtrair");
            Console.WriteLine("\r Digite 3 para Multiplicar");
            Console.WriteLine("\r Digite 4 para Dividir");
            Console.WriteLine("\r Digite S para sair");

            Console.WriteLine();

            string operacao = Console.ReadLine();

            if (operacao == "S" || operacao == "s")
            {
                break;
            }

            if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao == "s")
            {
                Console.WriteLine("Operação Inválida, tente novamente!");
                Console.ReadLine();
                continue; //volta para o início do laço
            }

            Console.WriteLine();

            Console.Write("\r Digite o primeiro número: ");

            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\r Digite o segundo número: ");

            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = 0;
            if (operacao == "1")
            {
                resultado = primeiroNumero + segundoNumero;
            }
            else if (operacao == "2")
            {
                resultado = primeiroNumero - segundoNumero;
            }
            else if (operacao == "3")
            {
                resultado = primeiroNumero * segundoNumero;
            }
            else if (operacao == "4")
            {
                while (segundoNumero == 0)
                {
                    Console.WriteLine("O segundo número não pode ser ZERO, tente novamente.");

                    Console.ReadLine();

                    Console.Write("Digite o segundo número: ");

                    segundoNumero = Convert.ToInt32(Console.ReadLine());
                }

                resultado = primeiroNumero / segundoNumero;
            }

            decimal resultadoFormatado = Math.Round(resultado, 2);

            Console.WriteLine("\n\r O resultado da sua operação é: " + resultadoFormatado);

            Console.ReadLine();

        } while (true);
    }
}