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
    public partial class Start : Form
    {
        //Array para armezar os valores caso o usuário escolha adicionar manualmente
        int[] numeros = new int[1];

        //Variavel de controle
        int pos = 0;

        public Start()
        {
            InitializeComponent();
        }

        //Chamar o menu Ordenacao.cs com números aleatórios
        private void button1_Click(object sender, EventArgs e)
        {
            Ordenacao ordernar = new Ordenacao();

            ordernar.Show();
        }

        //Chamar o menu Ordenacao.cs com números informados pelo usuário
        private void button2_Click(object sender, EventArgs e)
        {
            //Ocultar os botões que não serão mais utilizados (Gerar números aleatórios, Adicionar valores)
            this.button1.Hide();
            this.button2.Hide();

            //Mostrar os botões Adicionar e Finalizar e o campo texto
            this.button3.Show();
            this.button4.Show();
            this.textBox1.Show();
        }

        //Finalizar a operação adicionar no array e partir para a ordenação
        private void button3_Click(object sender, EventArgs e)
        {
            Ordenacao ordernar = new Ordenacao(numeros);

            ordernar.Show();
        }

        //Adicionar os valores no Array
        private void button4_Click(object sender, EventArgs e)
        {
            //Crescer o Array em tempo de execução
            Array.Resize(ref numeros, numeros.Length + 1);

            //Capturando o valor no campo texto e trazendo para o array
            numeros[pos] = int.Parse(this.textBox1.Text);
            
            //Teste de impressão para ver se estar funcionando
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + ", ");
            }
            Console.WriteLine(" ");

            this.textBox1.Clear();

            //incrementando uma posicão no array
            pos++;
        }

        //Campo texto
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
