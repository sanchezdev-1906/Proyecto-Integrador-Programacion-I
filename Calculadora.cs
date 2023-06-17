namespace Proyecto_Integrador_Programacion_I
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        private void MostrarVentana(Form opcion)
        {
            if (pnlPrincipal.Controls.Count > 0)
                pnlPrincipal.Controls.Clear();
            opcion.TopLevel = false;
            opcion.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(opcion);
            opcion.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarVentana(new OpConjuntos());
        }
    }
}