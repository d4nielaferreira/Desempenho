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
        }


    }
}
