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
        int[] numeros;

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

        //Finalizar
        private void button3_Click(object sender, EventArgs e)
        {
            Ordenacao ordernar = new Ordenacao(numeros);
        }

        //Adicionar
        private void button4_Click(object sender, EventArgs e)
        {

        }

        //Campo texto
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
