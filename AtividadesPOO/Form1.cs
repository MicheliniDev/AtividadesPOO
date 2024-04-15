using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadesPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double distancia, resultado;
            distancia = Convert.ToDouble(txtDistancia.Text);
            if (distancia < 800)
            {
                resultado = 5000;
                txtResposta.Text = resultado.ToString();
            }
            else
            {
                resultado = 10000;
                txtResposta.Text = resultado.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDistancia.Clear();
            txtResposta.Clear();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 tela1 = new Form2();
            tela1.Show();
        }

        private void continuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 tela3 = new Form3();
            tela3.Show();
        }
    }
}
