using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desempenho
{
    class Program
    {
        static void Main(string[] args)
        {
            Binario Teste = new Binario();
            Teste.PesquisaBinaria();

            int[] arr = { 10, 64, 7, 52, 32, 18, 2, 48 };
            HeapSort hs = new HeapSort();
            Console.WriteLine(hs.tempoinicio.ToString("h:mm:ss.fff tt"));
            hs.PerformHeapSort(arr);
            Console.WriteLine();
            Console.WriteLine(hs.tempofinal.ToString("h:mm:ss.fff tt"));
            Console.ReadLine();
        }


    }
}
