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
<<<<<<< HEAD
            int option;

            Console.WriteLine("Escolha o método");
            option = int.Parse(Console.ReadLine());

            if(option == 1)
            {
                Bubble bubble = new Bubble();
            }

            if (option == 2)
            {
                QuickSort quick = new QuickSort();
            }

            if (option == 3)
            {
                HeapSort heap = new HeapSort();
            }
=======
            Binario Teste = new Binario();
            Teste.PesquisaBinaria();

            int[] arr = { 10, 64, 7, 52, 32, 18, 2, 48 };
            HeapSort hs = new HeapSort();
            Console.WriteLine(hs.tempoinicio.ToString("h:mm:ss.fff tt"));
            hs.PerformHeapSort(arr);
            Console.WriteLine();
            Console.WriteLine(hs.tempofinal.ToString("h:mm:ss.fff tt"));
            Console.ReadLine();
>>>>>>> 13abd6f21678b7200720b7188ee53a6c05c4cdb6
        }


    }
}
