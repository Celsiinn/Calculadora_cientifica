using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeiro_numero, segundo_numero, resultado;
            int operaçao, potencia, porcentagem;
            string escolha;
           
            INICIO:
                Console.WriteLine("Bem vindo a calculadora");
                Console.WriteLine("Escolha a Operacao");
                Console.WriteLine("1 - Adiçao , 2 - Subtracao , 3 - Multiplicaçao , 4 - Divisao ,5 - Potenciacao ,6 - Porcentagem , 7 - Radiciacao");
                operaçao = int.Parse(Console.ReadLine());

                switch (operaçao)
                {
                    case 1:
                        Console.WriteLine("Informe o Primeiro numero");
                        primeiro_numero = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo numero");
                        segundo_numero = double.Parse(Console.ReadLine());
                        resultado = primeiro_numero + segundo_numero;
                        Console.WriteLine($"O Resultado da soma é = {resultado}");
                    goto INICIO;
                    break;
                    case 2:
                        Console.WriteLine("Informe o Primeiro numero");
                        primeiro_numero = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo numero");
                        segundo_numero = double.Parse(Console.ReadLine());
                        resultado = primeiro_numero - segundo_numero;
                        Console.WriteLine($"O Resultado da Subtraçao é = {resultado}");
                    goto INICIO;
                    break;
                    case 3:
                        Console.WriteLine("Informe o Primeiro numero");
                        primeiro_numero = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo numero");
                        segundo_numero = double.Parse(Console.ReadLine());
                        resultado = primeiro_numero * segundo_numero;
                        Console.WriteLine($"O Resultado da multiplicaçao é = {resultado}");
                    goto INICIO;
                    break;
                    case 4:
                        Console.WriteLine("Informe o Primeiro numero");
                        primeiro_numero = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo numero");
                        segundo_numero = double.Parse(Console.ReadLine());
                        resultado = primeiro_numero * segundo_numero;
                        Console.WriteLine($"O Resultado da divisao é = {resultado}");
                    goto INICIO;
                        break;
                    case 5:
                        Console.WriteLine("Informe o numero");
                        primeiro_numero = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a Potencia");
                        potencia = int.Parse(Console.ReadLine());
                        resultado = Math.Pow(primeiro_numero, potencia);
                        Console.WriteLine($"O Resultado da Potencia é = {resultado}");
                    goto INICIO;
                    break;
                    case 6:
                        Console.WriteLine("Informe a porcentagem");
                        porcentagem = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o numero");
                        primeiro_numero = double.Parse(Console.ReadLine());
                        resultado = (primeiro_numero * porcentagem) / 100;
                        Console.WriteLine($"{porcentagem}% de {primeiro_numero} é = {resultado}");
                    goto INICIO;
                    break;
                    case 7:
                        Console.WriteLine("Informe o numero");
                        primeiro_numero = double.Parse(Console.ReadLine());
                        resultado = Math.Sqrt(primeiro_numero);
                        Console.WriteLine($"A raiz é = {resultado}");
                    goto INICIO;
                    break;

                    default:
                        Console.WriteLine("Opcao invalida");
                        Console.WriteLine("Deseja Calcular mais alguma coisa?");
                    
                    goto INICIO;
                    break;
                    
                }

            Console.ReadKey();
               
            
        }   
    }
}
