using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum Menu
        {
            Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair
        }

        static void Soma()
        {
            Console.WriteLine("Digite o primeiro fator:");
            double firstAdd = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo fator:");
            double secAdd = double.Parse(Console.ReadLine());
            Console.WriteLine($"{firstAdd} + {secAdd} = {firstAdd + secAdd}");
        }

        static void Subtracao()
        {
            Console.WriteLine("Digite o primeiro fator:");
            double firstAdd = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo fator:");
            double secAdd = double.Parse(Console.ReadLine());
            Console.WriteLine($"{firstAdd} - {secAdd} = {firstAdd - secAdd}");
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro fator:");
            double firstAdd = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo fator:");
            double secAdd = double.Parse(Console.ReadLine());
            Console.WriteLine($"{firstAdd} * {secAdd} = {firstAdd * secAdd}");
        }

        static void Divisao()
        {
            Console.WriteLine("Digite o primeiro fator:");
            double firstAdd = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo fator:");
            double secAdd = double.Parse(Console.ReadLine());

            if(secAdd == 0)
            {
                Console.WriteLine("ERRO! DIVISÃO POR ZERO.");
            }
            else
            {
                Console.WriteLine($"{firstAdd} / {secAdd} = {firstAdd / secAdd}");
            }
        }

        static void Potencia()
        {
            Console.WriteLine("Digite o primeiro fator (base):");
            double firstAdd = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo fator (expoente):");
            double secAdd = double.Parse(Console.ReadLine());
            Console.WriteLine($"{firstAdd} ^ {secAdd} = {Math.Pow(firstAdd, secAdd)}");
        }

        static void Raiz()
        {
            Console.WriteLine("Digite o primeiro fator (radicando):");
            double firstAdd = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo fator (indice):");
            double secAdd = double.Parse(Console.ReadLine());
            Console.WriteLine($" {secAdd}√{firstAdd} = {Math.Pow(firstAdd, Math.Pow(secAdd, -1))}");
        }

        static void Main(string[] args)
        {
            
            bool escolheuSair = true;
            while(escolheuSair)
            {
                Console.WriteLine("Calculadora zdd");
                Console.WriteLine("\nDigite a opção desejada:\n1- Somar\n2- Subtrair\n3- Dividir\n4- Multiplicar\n5- Potência\n6- Raiz Quadrada\n7- Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine()); //Casting de int pra Menu

                switch(opcao)
                {
                    case Menu.Soma:
                    Soma();
                    Console.WriteLine("Aperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    break;

                    case Menu.Subtracao:
                    Subtracao();
                    Console.WriteLine("Aperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    break;

                    case Menu.Multiplicacao:
                    Multiplicacao();
                    Console.WriteLine("Aperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    break;

                    case Menu.Divisao:
                    Divisao();
                    Console.WriteLine("Aperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    break;
                    
                    case Menu.Potencia:
                    Potencia();
                    Console.WriteLine("Aperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    break;

                    case Menu.Raiz:
                    Raiz();
                    Console.WriteLine("Aperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    break;

                    case Menu.Sair:
                    escolheuSair = false;
                    break;
                }

                

                Console.Clear();
            }
            
        }
    }
}
