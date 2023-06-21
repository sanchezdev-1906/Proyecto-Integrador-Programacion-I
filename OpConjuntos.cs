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
