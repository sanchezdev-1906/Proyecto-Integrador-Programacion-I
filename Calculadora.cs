namespace Proyecto_Integrador_Programacion_I
{
    public partial class Calculadora : Form
    {
        
        public Calculadora()
        {
            InitializeComponent();
            ConjuntosElementos.Add("A", new HashSet<int>());
            ConjuntosElementos.Add("B", new HashSet<int>());
            ConjuntosElementos.Add("C", new HashSet<int>());

        }
    }
}