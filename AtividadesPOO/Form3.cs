using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AtividadesPOO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 tela1 = new Form2();
            tela1.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        double salarioFinal, abono;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario, idade;
            string sexo;
            idade = Convert.ToDouble(txtIdade.Text);
            salario = Convert.ToDouble(txtSalario.Text);
            sexo = txtSexo.Text;
            if (idade >= 30 && sexo == "M")
            {
                abono = 100;
                salarioFinal = salario + abono;
            }
            else if (idade < 30 && sexo == "F")
            {
                abono = 50;
                salarioFinal = salario + abono;
            }
            else if (idade >= 30 && sexo == "F")
            {
                abono = 200;
                salarioFinal = salario + abono;
            }
            else if (idade < 30 && sexo == "M")
            {
                abono = 80;
                salarioFinal = salario + abono;
            }
            txtAbono.Text = abono.ToString();
            txtSalarioFinal.Text = salarioFinal.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAbono.Clear();
            txtSalarioFinal.Clear();
            txtIdade.Clear();
            txtSexo.Clear();
            txtSalario.Clear();
        }
    }
}
