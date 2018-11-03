using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desempenho
{
    public class Bolha
    {
        public Bolha()
        {
            int[] vetor = new int[1000];

            Console.WriteLine("Ordena��o Bolha");

            ordena(vetor, vetor.Length);

            for (int i = 0; i < vetor.Length; i++)
                Console.WriteLine(vetor[i]);

            Console.ReadLine();
        }

        public static void ordena(int[] arr, int length)
        {
            int aux = 0;
            /*Ir� percorrer o vetor, comparando cada elemento do vetor com o elemento 
             * imediatamente seguinte (arr[j] = arr[j + 1];) 
             * O numero maximo de execu��es do trecho do algoritmo 
             * p/ que o vetor fique ordenado � de N - 1, onde N � o numero de vezes.*/

            // i determina o n�mero de etapas para a ordena��o 
            for (int i = 0; i < length - 1; i++)
            {
                // j determina o numero de compara��es em cada etapa e os indices a serem 
                //pesquisados para a compara��o. 
                for (int j = 0; j < length - (i + 1); j++)
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
