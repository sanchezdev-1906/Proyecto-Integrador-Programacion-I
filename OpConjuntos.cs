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
            Pen penU = new Pen(Color.Black, 2);
            e.Graphics.DrawRectangle(penU, rectU);

            Brush brushConjuntos = new SolidBrush(Color.FromArgb(120, 57, 126, 214));

            Rectangle rectA = new Rectangle(centroX - 100 - 50, 25, 200, 200);
            GraphicsPath circleA = new GraphicsPath();
            circleA.AddEllipse(rectA);
            Region A = new Region(circleA);

            Rectangle rectB = new Rectangle(centroX - 100 + 50, 25, 200, 200);
            GraphicsPath circleB = new GraphicsPath();
            circleB.AddEllipse(rectB);
            Region B = new Region(circleB);

            Rectangle rectC = new Rectangle(centroX - 100, 100, 200, 200);
            GraphicsPath circleC = new GraphicsPath();
            circleC.AddEllipse(rectC);
            Region C = new Region(circleC);

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
            e.Graphics.FillRegion(brushConjuntos, A);
            e.Graphics.FillRegion(brushConjuntos, B);
            if (rBtnConjs3.Checked == true)
                e.Graphics.FillRegion(brushConjuntos, C);

            if (txtOper.Text != "")
            {
                Region Res = Graficos.GenerarGrafico(txtOper.Text);
                Brush penR = new SolidBrush(Color.FromArgb(200, 251, 85, 109));
                e.Graphics.FillRegion(penR, Res);
            }
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if(Regex.Match(txtOper.Text, @"^P\([ABC]\)").Success)
            {
                return;
            }
            
            PnlGraficos.Invalidate();
            if (txtOper.Text == "") return;
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
            string[] ConjuntoResultante = Conjuntos.CalcularConjuntos(txtOper.Text).ToArray();
            int[] Resultados;

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
    }
}
