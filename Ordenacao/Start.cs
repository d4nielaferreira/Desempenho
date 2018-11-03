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
        public Start()
        {
            InitializeComponent();
        }

        //Gerar aleatórios e chamar o form1
        private void button1_Click(object sender, EventArgs e)
        {
            Ordenacao ordernar = new Ordenacao();

            ordernar.Show();
        }
    }
}
