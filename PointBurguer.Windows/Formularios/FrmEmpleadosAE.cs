using PointBurger.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointBurger.Windows.Formularios
{
    public partial class FrmEmpleadosAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        public FrmEmpleadosAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private Empleado empleado = null!;
        public Empleado GetTipo()
        {
            return empleado;
        }
        public void SetTipo(Empleado tipoEmpleado)
        {
            empleado = tipoEmpleado;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                if (empleado == null)
                {
                    empleado = new Empleado();
                }
                empleado.Nombre = txtNombre.Text;
                empleado.Apellido = txtApellido.Text;
                empleado.FechaNac = dtpFechaNac.Value;
                empleado.Telefono = int.Parse(txtTelefono.Text);
                empleado.Salario = int.Parse(txtSalario.Text);
                empleado.Comision = int.Parse(txtComision.Text);

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtNombre, "El Nombre es requerido");
            }
            if (string.IsNullOrEmpty(txtApellido.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtApellido, "El Apellido es requerido");
            }
            if (string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtTelefono, "El Telefono es requerido");
            }
            if (string.IsNullOrEmpty(txtSalario.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtSalario, "El Salario es requerido");
            }
            if (string.IsNullOrEmpty(txtComision.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtComision, "La Comision es requerido");
            }
            return valido;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (empleado != null)
            {
                txtNombre.Text = empleado.Nombre;
                txtApellido.Text = empleado.Apellido;
                dtpFechaNac.Value = empleado.FechaNac;
                txtTelefono.Text = empleado.Telefono.ToString();
                txtSalario.Text = empleado.Salario.ToString();
                txtComision.Text = empleado.Comision.ToString();

            }
        }
    }
}
