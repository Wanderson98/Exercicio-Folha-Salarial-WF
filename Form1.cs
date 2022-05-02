using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula52Exercicio.Services;

namespace Aula52Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFreeLancer.Checked)
            {
                txtValorProjeto.Visible = true;
                lblValorProjeto.Visible = true;
            }
            else
            {
                txtValorProjeto.Visible = false;
                lblValorProjeto.Visible = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtColaborador.Text;
            double salarioBruto = double.Parse(txtSalarioBruto.Text);
            
            double salarioLiquido = 0;
            if (rbtnCLT.Checked)
            {
               salarioLiquido = CalculoFolhaSalarial.CalculoClt(salarioBruto);

            } else if (rbtnPJ.Checked)
            {
                salarioLiquido = CalculoFolhaSalarial.CalculoPJ(salarioBruto);

            } else if (rbtnFreeLancer.Checked)
            {
                double projeto = double.Parse(txtValorProjeto.Text);
                salarioLiquido = CalculoFolhaSalarial.CalculoFreeLancer(salarioBruto, projeto);
            }
          
            lblSalarioLiquido.Text = $"Nome: {nome}, Salário Líquido: R$ {salarioLiquido:F2}";

            txtColaborador.Text = null;
            txtValorProjeto.Text = null;
            txtSalarioBruto.Text = null;
        }
    }
}
