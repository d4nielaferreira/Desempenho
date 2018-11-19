using System;
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
        //iniciando o array para armezar os números a serem ordenados
        int[] numeros;

        //Método construtor para quando for aleatório
        public Ordenacao()
        {
            numeros = aleatorio();

            InitializeComponent();
        }

        //Método construtor para quando os números forem do usuário
        public Ordenacao(int[] n)
        {
            numeros = n;

            InitializeComponent();
        }

        //Chamando o métodos BubbleSort
        private void button1_Click(object sender, EventArgs e)
        {
            //Passando os valores aleatórios
            Bubble bubble = new Bubble(numeros);

            bFinal.Text = "Duração: " + bubble.final + "ms";
        }

        //Chamando o métodos HeapSort
        private void button2_Click(object sender, EventArgs e)
        {
            //Passando os valores aleatórios
            HeapSort heap = new HeapSort(numeros);

            hFinal.Text = "Duração: " + heap.final + "ms";
        }

        //Chamando o métodos quicksort
        private void button3_Click(object sender, EventArgs e)
        {
            //Passando os valores aleatórios
            QuickSort quick = new QuickSort(numeros);

            qFinal.Text = "Duração: " + quick.final + "ms";
        }

        //Método para gerar os números aleatóriamente
        public int[] aleatorio()
        {
            //Iniciando as variáveis para efetuar a geração dos valores aleatórios
            int Min = 0, Max = 100000;
            int[] numeros = new int[100000];

            //Gerando os números aleatórios
            Random randNum = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = randNum.Next(Min, Max);
            }

            return numeros;
        }

        private void Ordenacao_Load(object sender, EventArgs e)
        {

        }

        private void qInicio_Click(object sender, EventArgs e)
        {

        }

        private void qFinal_Click(object sender, EventArgs e)
        {

        }

        private void bFinal_Click(object sender, EventArgs e)
        {

        }
    }
}
