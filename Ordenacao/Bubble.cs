using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao
{
    class Bubble
    {

        public string final;

        public Bubble(int[] vetor)
        {
            Stopwatch timer = new Stopwatch();

            timer.Start();

            Bolha(vetor);

            timer.Stop();

            final = timer.ElapsedMilliseconds.ToString();

            

        }

        static void Bolha(int[] arr)
        {
            int aux = 0;
            /*Ir� percorrer o vetor, comparando cada elemento do vetor com o elemento 
             * imediatamente seguinte (arr[j] = arr[j + 1];) 
             * O numero maximo de execu��es do trecho do algoritmo 
             * p/ que o vetor fique ordenado � de N - 1, onde N � o numero de vezes.*/

            // i determina o n�mero de etapas para a ordena��o 
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // j determina o numero de compara��es em cada etapa e os indices a serem 
                //pesquisados para a compara��o. 
                for (int j = 0; j < arr.Length - (i + 1); j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        aux = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = aux;
                    }
                }
            }
        }
    }
}
