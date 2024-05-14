using System.Security.Cryptography.X509Certificates;

namespace TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int counterTotal = 0;
            char caracter;
            double hTotal = 0, mTotal = 0, cTotal = 0, iTotal = 0;
            double hPorcentagem = 0, mPorcentagem = 0, cPorcentagem = 0, iPorcentagem = 0;

            while (flag)
            {
                Console.WriteLine("H - homem, M - mulher, C - criança, I - idoso, F - finalizar");
                Console.WriteLine("Entre com um caractere:");
                caracter = char.Parse(Console.ReadLine());
                if(caracter == 'F')
                {
                    flag = false;
                }
                else
                {
                    counterTotal += 1;

                    if (caracter == 'H')
                    {
                        hTotal += 1;
                    }
                    else if (caracter == 'M')
                    {
                        mTotal += 1;
                    }
                    else if (caracter == 'C')
                    {
                        cTotal += 1;
                    }
                    else if (caracter == 'I')
                    {
                        iTotal += 1;
                    }
                }
            }

            hPorcentagem = hTotal != 0 ? CalculaPorcentagem(counterTotal, hTotal) : 0;
            mPorcentagem = mTotal != 0 ? CalculaPorcentagem(counterTotal, mTotal) : 0;
            cPorcentagem = cTotal != 0 ? CalculaPorcentagem(counterTotal, cTotal) : 0;
            iPorcentagem = iTotal != 0 ? CalculaPorcentagem(counterTotal, iTotal) : 0;

            Console.WriteLine("Total de homens: " + hTotal + " - " + hPorcentagem + "%");
            Console.WriteLine("Total de mulheres: " + mTotal + " - " + mPorcentagem + "%");
            Console.WriteLine("Total de crianças: " + cTotal + " - " + cPorcentagem + "%");
            Console.WriteLine("Total de idosos: " + iTotal + " - " + iPorcentagem + "%");

             int iSuperior = 0, iInferior = 0;
             int totalPar = 0, totalImpar = 0;
             Console.WriteLine("Entre com o intervalo inferior:");
             iInferior = int.Parse(Console.ReadLine());
             Console.WriteLine("Entre com o intervalo superior:");
             iSuperior = int.Parse(Console.ReadLine());

             for (int i = iInferior;  i <= iSuperior; i++)
             {
                if(i % 2 == 0) totalPar += i;
                else totalImpar += i;
             }

             Console.WriteLine("Soma dos pares: " + totalPar);
             Console.WriteLine("Soma dos ímpares: " + totalImpar);

             Console.WriteLine("Digite um número: ");
             int numero = int.Parse(Console.ReadLine());
             Console.WriteLine("Os números primos são: ");

             for (int i = 2; i <= numero; i++)
             {
                 bool ePrimo = true;
                 for (int j = 2; j < i; j++)
                 {
                     if (i % j == 0)
                     {
                         ePrimo = false;
                         break;
                     }
                 }
                 if (ePrimo)
                 {
                     Console.WriteLine(i);
                 }
             }
        }
        public static double CalculaPorcentagem(double counterTotal, double pessoa)
        {
            return (pessoa / counterTotal) * 100;
        }
    }
}
