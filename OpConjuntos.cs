using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private void PnlGraficos_Paint(object sender, PaintEventArgs e)
        {
            int centroX = PnlGraficos.Width / 2;

            if (rBtnConjs3.Checked == true)
            {
                PnlGraficos.Height = 451;
            }
            else
            {
                PnlGraficos.Height = 301;
            }

            Rectangle rectU = new Rectangle(centroX - 250, 0, 500, PnlGraficos.Height);
            Region U = new Region(rectU);
            Pen penU = new Pen(Color.Black);
            e.Graphics.DrawRectangle(penU,rectU);

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

            try
            {
                A = Conjuntos.CrearConjunto(txtConjA.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la exprecion\n(Conjunto A)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HashSet<string> B;
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
            HashSet<string> C = new HashSet<string>();
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
            txtOper.SelectedText += "∩";
        }

        private void BtnUnionChart_Click(object sender, EventArgs e)
        {
            txtOper.SelectedText += "∪";
        }

        private void BtnDiferenciaChart_Click(object sender, EventArgs e)
        {
            txtOper.SelectedText += "−";
        }

        private void BtnDifSimeChart_Click(object sender, EventArgs e)
        {
            txtOper.SelectedText += "∆";
        }

        private void BtnCompleChart_Click(object sender, EventArgs e)
        {
            txtOper.SelectedText += "ᶜ";
        }

        private void BtnVacioChart_Click(object sender, EventArgs e)
        {
            txtOper.SelectedText += "∅";
        }

        private void BtnAchart_Click(object sender, EventArgs e)
        {   
            txtOper.SelectedText += "A";
        }

        private void BtnBchar_Click(object sender, EventArgs e)
        {
            txtOper.SelectedText += "B";
        }

        private void BtnCchar_Click(object sender, EventArgs e)
        {
            txtOper.SelectedText += "C";
        }

        private void BtnUchar_Click(object sender, EventArgs e)
        {
            txtOper.SelectedText += "U";
        }
    }
}
