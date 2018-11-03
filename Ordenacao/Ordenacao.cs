﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenacao
{
    public partial class Ordenacao : Form
    {
        //Iniciando as variáveis para efetuar a geração dos valores aleatórios
        int Min = 0, Max = 100000;
        int[] numeros = new int[100000];

        public Ordenacao()
        {
            InitializeComponent();
        }

        //Chamando o métodos BubbleSort
        private void button1_Click(object sender, EventArgs e)
        {
            //Passando os valores aleatórios
            Bubble bubble = new Bubble(numeros);
        }

        //Chamando o métodos HeapSort
        private void button2_Click(object sender, EventArgs e)
        {
            //Passando os valores aleatórios
            HeapSort quick = new HeapSort();
        }

        //Chamando o métodos quicksort
        private void button3_Click(object sender, EventArgs e)
        {
            //Passando os valores aleatórios
            QuickSort heap = new QuickSort(numeros);
        }

        public void Ordenacao_Load(object sender, EventArgs e)
        {
            //Gerando os números aleatórios
            Random randNum = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = randNum.Next(Min, Max);
            }
        }
    }
}
