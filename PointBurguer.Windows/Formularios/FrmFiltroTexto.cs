namespace PointBurger.Windows.Formularios
{
    public partial class FrmFiltroTexto : Form
    {
        private string textoBusqueda = string.Empty;
        public FrmFiltroTexto()
        {
            InitializeComponent();
        }
        public string GetTexto() => textoBusqueda;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTexto.Text.Trim()))
            {
                textoBusqueda = txtTexto.Text.Trim();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
