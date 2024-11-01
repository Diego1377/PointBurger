using PointBurger.Entidades.Entidades;

namespace PointBurger.Windows.Formularios
{
    public partial class FrmCategoriasAE : Form
    {
        public FrmCategoriasAE()
        {
            InitializeComponent();
        }

        private Categoria categoria = null!;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                if (categoria == null)
                {
                    categoria = new Categoria();
                }
                categoria.Nombre = txtCategoria.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtCategoria.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtCategoria, "La Categoria es requerido");
            }
            return valido;
        }
        public Categoria GetTipo()
        {
            return categoria;
        }
        public void SetTipo(Categoria tipoCategoria)
        {
            categoria = tipoCategoria;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (categoria != null)
            {
                txtCategoria.Text = categoria.Nombre;
            }
        }
    }
}
