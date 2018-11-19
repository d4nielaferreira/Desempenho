using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ordenacao
{
    class QuickSort
    {
        public string final;

        public QuickSort(int[] numeros)
        {
            Stopwatch timer  = new Stopwatch();

            timer.Start();

            quickSortRecursive(numeros, 0, numeros.Length -1);
            timer.Stop();
            
            final = timer.ElapsedMilliseconds.ToString();
        }

        static public void quickSortRecursive(int[] vetor, int primeiro, int ultimo)
        {

            int baixo, alto, meio, pivo, repositorio;
            baixo = primeiro;
            alto = ultimo;
            meio = (int)((baixo + alto) / 2);

            pivo = vetor[meio];

            while (baixo <= alto)
            {
                while (vetor[baixo] < pivo)
                    baixo++;
                while (vetor[alto] > pivo)
                    alto--;
                if (baixo < alto)
                {
                    repositorio = vetor[baixo];
                    vetor[baixo++] = vetor[alto];
                    vetor[alto--] = repositorio;
                }
                else
                {
                    if (baixo == alto)
                    {
                        baixo++;
                        alto--;
                    }
                }
            }

            if (alto > primeiro)
                quickSortRecursive(vetor, primeiro, alto);
            if (baixo < ultimo)
                quickSortRecursive(vetor, baixo, ultimo);
        }
    }
}
