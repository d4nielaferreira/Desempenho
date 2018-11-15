using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao
{
    class HeapSort
    {
        private int heapSize;
        private DateTime tempoinicio = DateTime.Now;
        private DateTime tempofinal;

        public string inicio;
        public string final;

        public HeapSort(int[] vetor)
        {
            inicio = tempoinicio.ToString("hh:mm:ss.fff tt");

            PerformHeapSort(vetor);

            tempofinal = DateTime.Now;
            final = tempofinal.ToString("hh:mm:ss.fff tt");
        }

        private void BuildHeap(int[] arr)
        {
            heapSize = arr.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                Heapify(arr, i);
            }
        }

        private void Swap(int[] arr, int x, int y)//function to swap elements
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        private void Heapify(int[] arr, int index)
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if (left <= heapSize && arr[left] > arr[index])
            {
                largest = left;
            }

            if (right <= heapSize && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                Swap(arr, index, largest);
                Heapify(arr, largest);
            }
        }
        public void PerformHeapSort(int[] arr)
        {
            BuildHeap(arr);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                heapSize--;
                Heapify(arr, 0);
            }
        }
    }
}
