using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao
{
    class QuickSort
    {
        private DateTime tempoinicio;
        private DateTime tempofinal;

        public string inicio;
        public string final;

        public QuickSort(int[] numeros)
        {
            tempoinicio = DateTime.Now;
            inicio = tempoinicio.ToString("hh:mm:ss.fff tt");

            quickSort(numeros);

            tempofinal = DateTime.Now;
            final = tempofinal.ToString("hh:mm:ss.fff tt");
        }

        private static int[] quickSort(int[] vetor)
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
                Console.WriteLine(vetor.Length);
            }
        }
    }
}
