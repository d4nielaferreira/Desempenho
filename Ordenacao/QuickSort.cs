using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao
{
    class QuickSort
    {
        public static DateTime tempoinicio = DateTime.Now;
        public static DateTime tempofinal;

        public QuickSort(int[] numeros)
        {
            Console.WriteLine("Ordenação QuickSort");

            Console.WriteLine(tempoinicio.ToString("h:mm:ss.fff tt"));
            quickSort(numeros);

            tempofinal = DateTime.Now;

            Console.WriteLine(tempofinal.ToString("h:mm:ss.fff tt"));
        }

        public static int[] quickSort(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            quickSort(vetor, inicio, fim);

            return vetor;
        }

        private static void quickSort(int[] vetor, int inicio, int fim)
        {

            if (inicio < fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i];

                        vetor[i] = vetor[f];

                        vetor[f] = troca;

                        i++;

                        f--;
                    }
                }

                vetor[inicio] = vetor[f];

                vetor[f] = p;

                quickSort(vetor, inicio, f - 1);

                quickSort(vetor, f + 1, fim);
            }
        }
    }
}
