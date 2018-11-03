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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //BubbleSort
        private void button1_Click(object sender, EventArgs e)
        {
            Bubble bubble = new Bubble();
        }

        //HeapSort
        private void button2_Click(object sender, EventArgs e)
        {
            QuickSort quick = new QuickSort();
        }

        //QuickSort
        private void button3_Click(object sender, EventArgs e)
        {
            HeapSort heap = new HeapSort();
        }
    }
}
