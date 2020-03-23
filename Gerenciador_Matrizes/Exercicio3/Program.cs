using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];
            Random randomNum = new Random();
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = randomNum.Next(1, 100);
            }

            ImprimirArray(valores);

            int primeiraPosicao = 100;
            int segundaPosicao = 100;
            while (primeiraPosicao < 0 || primeiraPosicao > valores.Length - 1)
            {
                Console.WriteLine("Digite uma posicao: ");
                primeiraPosicao = int.Parse(Console.ReadLine());
            }

            while (segundaPosicao < 0 || segundaPosicao > valores.Length - 1 || primeiraPosicao == segundaPosicao)
            {
                Console.WriteLine("Digite uma segunda posicao: ");
                segundaPosicao = int.Parse(Console.ReadLine());
            }

            int aux = valores[primeiraPosicao];
            valores[primeiraPosicao] = valores[segundaPosicao];
            valores[segundaPosicao] = aux;

            Console.WriteLine("Troca realizada!!!!\n");
            Console.WriteLine("------Novos valores------\n");
            ImprimirArray(valores);

        }

        static void ImprimirArray(int[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write(String.Format("numeros[{0}] = {1}   ", i, valores[i]));
            }
            Console.WriteLine("");
        }

    }
}
