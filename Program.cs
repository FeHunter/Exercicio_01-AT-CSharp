using System;

namespace AtCSharp
{
    class Program
    {
        static void Main ()
        {
            int nMaximo, primeiro, segundo, terceiro;

            Console.Write("\nDigite um valor iniciar a sequência Fibonacci: ");
            nMaximo = int.Parse(Console.ReadLine());

            primeiro = 0;
            segundo = 1;

            Console.Write($"{primeiro} {segundo}");

            // Mostra 10 números apartir do número informado.
            for (int i = 1; i < (nMaximo-1); i++){
                terceiro = primeiro + segundo;
                Console.Write($" {terceiro}");
                primeiro = segundo;
                segundo = terceiro;
            }
        }
    }
}