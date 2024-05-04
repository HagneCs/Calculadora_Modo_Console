using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora___Modo_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultado; //Declaração das variáveis utilizadas para armazenar os números do cálculo.

            string operador; //Declaração da variável utilizada para armazenar o operador do cálculo.

            Console.Title = "Calculadora - Modo Console"; //Altera o título do console para: Calculadora - Modo Console.

            while (true) //Laço de repetição que reinicia o programa quando o usuário digitar algum dado incorreto ou quando o usuário pressionar enter no final do programa.
            {
                //Mensagem de boas vindas ao programa.
                Console.WriteLine("\nOlá! Seja bem vindo ao programa: Calculadora em Modo Console.\n");

                //Mensagem explicando um pouco sobre como funciona o programa e quais os cálculos que ele realiza.
                Console.WriteLine("\nComo funciona?");
                Console.WriteLine("\nEssa calculadora faz o cálculo de dois números utilizando as quatro operações matemáticas básicas (observe os operadores abaixo):");
                Console.WriteLine("\nAdição: + \t Subtração: - \t\t Divisão: / \t Multiplicação: *\n");

                //Mensagem pedindo para o usuário digitar o primeiro número do cálculo.
                Console.Write("\nDigite o primeiro número: ");

                /* Converte o valor digitado pelo usuário em double, se for bem sucedido o método armazena o valor convertido na variável "numero1", caso não seja bem
                   sucedido retorna uma mensagem de erro ao usuário e uma mensagem de reiniciar o programa. */
                if (!Double.TryParse(Console.ReadLine(), out numero1))
                {
                    Console.WriteLine("\n\nNúmero inválido! Digite um número válido para continuar com o cálculo.");
                    Console.Write("\n\n\nO programa será reiniciado, pressione qualquer tecla para reiniciar...");
                    Console.ReadKey(); //Espera o usuário digitar qualquer tecla.
                    Console.Clear(); //Limpa todas as informações do console.

                    continue; //Pula as próximas etapas e retorna ao início do while / início do programa.
                }

                //Mensagem pedindo para o usuário digitar o operador do cálculo / Leia o operador digitado e armazene-o na variável "operador".
                Console.Write("\nDigite o operador: ");
                operador = Console.ReadLine();

                /* Método que verifica se a informação digitada e armazenada na variável "operador" é algum dos operadores permitidos (+, -, *, /), caso contrário,
                   retorna uma mensagem de erro ao usuário e uma mensagem de reiniciar o programa. */
                if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
                {
                    Console.WriteLine("\n\nOperador inválido! Digite um operador válido para continuar com o cálculo.");
                    Console.Write("\n\n\nO programa será reiniciado, pressione qualquer tecla para reiniciar...");
                    Console.ReadKey();
                    Console.Clear();

                    continue;
                }

                //Mensagem pedindo para o usuário digitar o segundo número do cálculo.
                Console.Write("\nDigite o segundo número: ");

                if (!Double.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.WriteLine("\n\nNúmero inválido! Digite um número válido para continuar com o cálculo.");
                    Console.Write("\n\n\nO programa será reiniciado, pressione qualquer tecla para reiniciar...");
                    Console.ReadKey();
                    Console.Clear();

                    continue;
                }
                
                /* Switch / case que verifica qual informação a variável "operador" armazena: "+", "-", "*", "/" e irá fazer o cálculo dos dois números com base no 
                   operador, armazenando o resultado na variável "resultado" e logo em seguida será mostrado o cálculo feito e o resultado para o usuário em uma mensagem 
                   no console */
                switch (operador)
                {
                    case "+":

                        resultado = numero1 + numero2;

                        Console.WriteLine($"\n\nCálculo: {numero1} + {numero2} = {resultado} \t\t Resultado: {resultado}");

                        break;

                    case "-":

                        resultado = numero1 - numero2;

                        Console.WriteLine($"\n\nCálculo: {numero1} - {numero2} = {resultado} \t\t Resultado: {resultado}");

                        break;

                    case "*":

                        resultado = numero1 * numero2;

                        Console.WriteLine($"\n\nCálculo: {numero1} * {numero2} = {resultado} \t\t Resultado: {resultado}");

                        break;

                    case "/":

                        //Método if que retorna um erro quando o usuário digitar o número 0 no segundo número em um cálculo de divisão.
                        if (numero2 == 0)
                        {
                            Console.WriteLine("\n\nNa divisão, o segundo número não pode ser igual a zero!");
                            Console.Write("\n\n\nO programa será reiniciado, pressione qualquer tecla para reiniciar...");
                            Console.ReadKey();
                            Console.Clear();

                            continue;
                        }

                        resultado = numero1 / numero2;

                        Console.WriteLine($"\n\nCálculo: {numero1} / {numero2} = {resultado} \t\t Resultado: {resultado}");

                        break;
                }

                //Mensagem pedindo para o usuário pressionar enter para reiniciar o programa ou qualquer outra tecla para fechar o programa.
                Console.Write("\n\n\nEnter: reincia o programa \t Qualquer outra tecla: fecha o programa");

                //Se o usuário pressionar enter: Limpe todos os dados do console e reinicie o programa, se não pressionar enter: Pare o programa.
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
