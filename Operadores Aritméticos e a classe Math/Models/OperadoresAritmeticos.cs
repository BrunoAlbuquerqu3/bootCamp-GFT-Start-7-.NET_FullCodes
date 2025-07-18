using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OperadoresAritmeticos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero.");
            }
            else
            {
                Console.WriteLine($"{x} / {y} = {(double)x / y}");
            }
        }
        public void Potencia(int x, int y)
        {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double Seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º  = {Math.Round(Seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double Coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}º  = {Math.Round(Coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double Tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(Tangente, 4)}");
        }
        public void RaizQuadrada(double x)
        {
            if (x < 0)
            {
                Console.WriteLine("Erro: Não é possível calcular a raiz quadrada de um número negativo");
                }
            else
            {
                Console.WriteLine($"Raiz quadrada de {x} = {Math.Sqrt(x)}");
            }
        }
    }
}
