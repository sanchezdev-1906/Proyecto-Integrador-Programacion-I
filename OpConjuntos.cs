using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
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
        private void PnlGraficos_Paint(object sender, PaintEventArgs e)
        {
            int centroX = PnlGraficos.Width / 2;

            int altura;
            if (rBtnConjs3.Checked == true)
            {
                PnlGraficos.Height = 500;
                altura = PnlGraficos.Height - 50;
            }
            else
            {
                PnlGraficos.Height = 350;
                altura = PnlGraficos.Height - 50;
            }

            Rectangle rectU = new Rectangle(centroX - 250, 0, 500, altura);
            Region U = new Region(rectU);
            Pen penU = new Pen(Color.Black);
            e.Graphics.DrawRectangle(penU, rectU);

            Rectangle rectA = new Rectangle(centroX - 100 - 50, 25, 200, 200);
            GraphicsPath circleA = new GraphicsPath();
            circleA.AddEllipse(rectA);
            Region A = new Region(circleA);
            Brush penA = new SolidBrush(Color.Red);

            Rectangle rectB = new Rectangle(centroX - 100 + 50, 25, 200, 200);
            GraphicsPath circleB = new GraphicsPath();
            circleB.AddEllipse(rectB);
            Region B = new Region(circleB);
            Brush penB = new SolidBrush(Color.Blue);

            Rectangle rectC = new Rectangle(centroX - 100, 100, 200, 200);
            GraphicsPath circleC = new GraphicsPath();
            circleC.AddEllipse(rectC);
            Region C = new Region(circleC);
            Brush penC = new SolidBrush(Color.Yellow);

            if (!(Graficos.ConjuntosElementos.Count > 0))
            {
                Graficos.ConjuntosElementos.Add("A", A);
                Graficos.ConjuntosElementos.Add("B", B);
                Graficos.ConjuntosElementos.Add("C", C);
                Graficos.ConjuntosElementos.Add("U", U);
            }
            else
            {
                Graficos.ConjuntosElementos["A"] = A;
                Graficos.ConjuntosElementos["B"] = B;
                Graficos.ConjuntosElementos["C"] = C;
                Graficos.ConjuntosElementos["U"] = U;
            }

            // Draw the path to the screen.
            e.Graphics.FillRegion(penA, A);
            e.Graphics.FillRegion(penB, B);
            if (rBtnConjs3.Checked == true)
                e.Graphics.FillRegion(penC, C);

            if (txtOper.Text != "")
            {
                Region Res = Graficos.GenerarGrafico(txtOper.Text);
                Brush penR = new SolidBrush(Color.Green);
                e.Graphics.FillRegion(penR, Res);
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            PnlGraficos.Invalidate();
            HashSet<string> A;
            HashSet<string> B;
            HashSet<string> C;

            try
            {
                A = Conjuntos.CrearConjunto(txtConjA.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}\nConjunto A", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                B = Conjuntos.CrearConjunto(txtConjB.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}\nConjunto B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                C = Conjuntos.CrearConjunto(txtConjC.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err.Message}\nConjunto C", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

            HashSet<string> U;
            U = Conjuntos.CalcularConjuntos("A∪B∪C");
            if (Conjuntos.ConjuntosElementos.Count < 1)
                Conjuntos.ConjuntosElementos.Add("U", U);
            else
                Conjuntos.ConjuntosElementos["U"] = U;

            string[] ConjuntoResultante = Conjuntos.CalcularConjuntos(txtOper.Text).ToArray();
            int[] Resultados;

            if (Regex.Match(txtOper.Text, @"^[A-C]x[A-C]$").Success)
            {
                string[] conjuntos = txtOper.Text.Split("x");
                string resultado = Conjuntos.ProductoCartesiano(Conjuntos.ConjuntosElementos[conjuntos[0]], Conjuntos.ConjuntosElementos[conjuntos[1]]);
                txtResultado.Text = resultado;
                return;
            }

            if (ConjuntoResultante.Length == 0)
            {
                txtResultado.Text = "∅";
            }
            else if (int.TryParse(ConjuntoResultante[0], out int n))
            {
                Resultados = Array.ConvertAll(ConjuntoResultante, int.Parse);
                txtResultado.Text = string.Join(",", Resultados.Order());
            }
            else
            {
                txtResultado.Text = string.Join(",", ConjuntoResultante.Order());
            }
        }

        private void rBtnConjs3_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnConjs3.Checked == true)
            {
                lblConjC.Visible = true;
                txtConjC.Visible = true;
                BtnCchar.Enabled = true;
            }
        }

        private void rBtnConjs2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnConjs2.Checked == true)
            {
                lblConjC.Visible = false;
                txtConjC.Visible = false;
                BtnCchar.Enabled = false;
            }
        }

        private void BtnInterChart_Click(object sender, EventArgs e)
        {
            EscribirTxt("∩");
        }

        private void BtnUnionChart_Click(object sender, EventArgs e)
        {
            EscribirTxt("∪");
        }

        private void BtnDiferenciaChart_Click(object sender, EventArgs e)
        {
            EscribirTxt("−");
        }

        private void BtnDifSimeChart_Click(object sender, EventArgs e)
        {
            EscribirTxt("∆");
        }

        private void BtnCompleChart_Click(object sender, EventArgs e)
        {
            EscribirTxt("ᶜ");
        }

        private void BtnVacioChart_Click(object sender, EventArgs e)
        {
            EscribirTxt("∅");
        }

        private void BtnAchart_Click(object sender, EventArgs e)
        {
            EscribirTxt("A");
        }

        private void BtnBchar_Click(object sender, EventArgs e)
        {
            EscribirTxt("B");
        }

        private void BtnCchar_Click(object sender, EventArgs e)
        {
            EscribirTxt("C");
        }

        private void BtnUchar_Click(object sender, EventArgs e)
        {
            EscribirTxt("U");
        }
        private void EscribirTxt(string caracter)
        {
            int cursor = txtOper.SelectionStart;
            int selectedChars = txtOper.SelectionLength;
            txtOper.Text = txtOper.Text.Remove(cursor, selectedChars);
            txtOper.Text = txtOper.Text.Insert(cursor, caracter);
            txtOper.Focus();
            txtOper.SelectionStart = cursor + 1;
            txtOper.SelectionLength = 0;
        }

        private void lblRes_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtOper_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
