using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador_Programacion_I
{
    public partial class OpConjuntos : Form
    {
        public OpConjuntos()
        {
            InitializeComponent();
            rBtnConjs2.Checked = true;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            HashSet<int> A;
            try
            {
                A = Conjuntos.CrearConjunto(txtConjA.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la exprecion\n(Conjunto A)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HashSet<int> B;
            try
            {
                B = Conjuntos.CrearConjunto(txtConjB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la exprecion\n(Conjunto B)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Conjuntos.ConjuntosElementos.Add("B", B);
            HashSet<int> C = new HashSet<int>();
            if (rBtnConjs3.Checked == true)
            {
                try
                {
                    C = Conjuntos.CrearConjunto(txtConjC.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la exprecion\n(Conjunto C)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (Conjuntos.ConjuntosElementos.Count < 1)
            {
                Conjuntos.ConjuntosElementos.Add("A", A);
                Conjuntos.ConjuntosElementos.Add("B", B);
                Conjuntos.ConjuntosElementos.Add("C", C);
            }
            else
            {
                Conjuntos.ConjuntosElementos["A"] = A;
                Conjuntos.ConjuntosElementos["B"] = B;
                Conjuntos.ConjuntosElementos["C"] = C;
            }
            HashSet<int> Resultado = Conjuntos.CalcularConjuntos(txtOper.Text);
            txtResultado.Text = string.Join(",", Resultado.Order());
        }

        private void rBtnConjs3_CheckedChanged(object sender, EventArgs e)
        {
            lblConjC.Visible = true;
            txtConjC.Visible = true;
        }

        private void rBtnConjs2_CheckedChanged(object sender, EventArgs e)
        {
            lblConjC.Visible = false;
            txtConjC.Visible = false;
        }

        private void BtnInterChart_Click(object sender, EventArgs e)
        {
            txtOper.Text += "∩";
        }

        private void BtnUnionChart_Click(object sender, EventArgs e)
        {
            txtOper.Text += "∪";
        }

        private void BtnDiferenciaChart_Click(object sender, EventArgs e)
        {
            txtOper.Text += "-";
        }

        private void BtnDifSimeChart_Click(object sender, EventArgs e)
        {
            txtOper.Text += "∆";
        }

        private void BtnCompleChart_Click(object sender, EventArgs e)
        {
            txtOper.Text += "ᶜ";
        }

        private void BtnVacioChart_Click(object sender, EventArgs e)
        {
            txtOper.Text += "∅";
        }

        private void BtnAchart_Click(object sender, EventArgs e)
        {
            txtOper.Text += "A";
        }

        private void BtnBchar_Click(object sender, EventArgs e)
        {
            txtOper.Text += "B";
        }

        private void BtnCchar_Click(object sender, EventArgs e)
        {
            txtOper.Text += "C";
        }

        private void BtnUchar_Click(object sender, EventArgs e)
        {
            txtOper.Text += "U";
        }
    }
}
