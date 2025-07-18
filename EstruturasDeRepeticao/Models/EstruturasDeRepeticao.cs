using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;



namespace EstruturaDeRepeticao.Models
{
    public class MinhasEstruturas
    {
        public void ExemploFOR(int NumeroBase)  //Aula 1 Estrutura de Repetição
        {
            Console.WriteLine($"\n--- Você vera a tabuado do Numero: {NumeroBase}");
            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{NumeroBase} X {contador} = {NumeroBase * contador}");
            }
        }

        public void ExemploWhile(int NumeroBase) // Aula 2 
        {
            Console.WriteLine($"Tetando Estrutura de repetição While como o numero : {NumeroBase}");

            int contador = 0;

            while (contador <= 10)
            {
                Console.WriteLine($"{contador}ºExecução {NumeroBase} x {contador} = {NumeroBase * contador}");
                contador++;
            }
        }

        public void ExemploDoWhile() // Aula 3
        {
            int soma = 0;
            int numero;
            do
            {
                Console.WriteLine("Digite um número");
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;

            } while (numero != 0);
            Console.WriteLine($"Total de numeros Digitados é: {soma}");
        }

        public void ExemploWhileSwitchCase() // Aula 4
        {
            bool exibirMenu = true;
            while (exibirMenu)
            {
                Console.Clear(); //Limpa a tela a cada interação
                 Console.WriteLine("=== Menu de opções ===");
                Console.WriteLine("=== Digite a sua opção ===");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Buscar Cliente");
                Console.WriteLine("3 - Apagar Cliente");
                Console.WriteLine("4 - Encerrar");
                 Console.WriteLine("=======================");
                String? opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastro de Cliente");
                        break;

                    case "2":
                        Console.WriteLine("Busca de Cliente");
                        break;

                    case "3":
                        Console.WriteLine("Apagar Cliente");
                        break;

                    case "4":
                        Console.WriteLine("Encerrar");
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }           
        }
    }
    
}   