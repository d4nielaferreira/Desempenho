using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desempenho
{
    class Binario
    {
        public void PesquisaBinaria()
        { 
        int achou, inicio, fim, meio, busca, TAM;
        int[] vetor = new int[1000];
        TAM = 1000;
            achou = 0;
            inicio = 0;
            fim = TAM - 1; 
            

            for (int i = 1; i <= TAM; i++)
            {
                vetor[i - 1] = i;
            }

            Console.WriteLine("Entre com um número inteiro a ser pesquisado: ");
            busca = int.Parse(Console.ReadLine());

            while (inicio <= fim)
            {
                meio = (inicio + fim) / 2;
                Console.WriteLine("Meio= " + meio);
                if (vetor[meio] == busca)
                {
                    achou = 1;
                }
                if (busca<vetor[meio])
                {
                    fim = meio - 1;
                }
                else
                    inicio = meio + 1;
            }

            if (achou == 1)
            {
                Console.WriteLine("Valor " + busca + " encontrado");
            }
            else
                Console.WriteLine("Valor não encontrado");


            Console.ReadLine();
        }
    }
}
