namespace Proyecto_Integrador_Programacion_I
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            MostrarVentana(new OpConjuntos());
            button1.ForeColor = Color.FromArgb(255, 233, 205, 93);
        }
        private void MostrarVentana(Form newForm)
        {
            if (pnlPrincipal.Controls.Count > 0)
                pnlPrincipal.Controls.Clear();
            newForm.TopLevel = false;
            pnlPrincipal.Controls.Add(newForm);
            CentrarElementoAlPanel();
            newForm.Show();
        }
        private void Calculadora_SizeChanged(object sender, EventArgs e)
        {

            CentrarElementoAlPanel();
        }
        private void CentrarElementoAlPanel()
        {

            int x;
            if (pnlPrincipal.Controls.Count > 0)
            {
                Control hijo = pnlPrincipal.Controls[0];

                //un poco de matematicas, restando los anchos y dividiendo entre 2
                x = (pnlPrincipal.Width / 2) - (hijo.Width / 2);

                //asignamos la nueva ubicación
                hijo.Location = new Point(x, hijo.Location.Y);
            }
        }
    }
}