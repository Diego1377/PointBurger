using Microsoft.Extensions.DependencyInjection;
using PointBurger.Entidades.Dtos;
using PointBurger.Entidades.Entidades;
using PointBurger.Windows.Formularios;
using PointBurger.Windows.Helpers;
using PointBurguer.Servicios.Interfaces;
using System.Drawing.Printing;

namespace PointBurguer.Windows.Formularios
{
    public partial class FrmCategorias : Form
    {
        public List<Categoria> lista = null!;
        private readonly IServiciosCategorias? _servicio;
        private readonly IServiceProvider? _serviceProvider;
        public FrmCategorias(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicio = serviceProvider?.GetService<IServiciosCategorias>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            try
            {

                lista = _servicio!.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (var categoria in lista)
            {
                var r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, categoria);
                GridHelper.AgregarFila(r, dgvDatos);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCategoriasAE frm = new FrmCategoriasAE() { Text = "Nueva Categoria" };
            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Categoria categoria = frm.GetTipo();
                if (!_servicio!.Existe(categoria))
                {
                    _servicio!.Guardar(categoria);
                    var r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, categoria);
                    GridHelper.AgregarFila(r, dgvDatos);
                    MessageBox.Show("Registro agregado",
                                    "Mensaje",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente\nAlta denegada",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];

            Categoria? categoria = null!;
            if (r.Tag != null)
            {
                categoria = (Categoria)r.Tag;

            }
            try
            {
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja la Categoria {categoria.Nombre}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.No)
                {
                    return;     // Si se presiona No, cancelar
                }

                if (!_servicio!.EstaRelacionado(categoria.CategoriaId))
                {
                    _servicio!.Borrar(categoria.CategoriaId);

                    GridHelper.QuitarFila(r, dgvDatos);
                    MessageBox.Show("Registro eliminado satisfactoriamente",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registro relacionado\nBaja Denegada",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)   // Si no hay filas seleccionadas, salgo
            {
                return;
            }
            try
            {
                var r = dgvDatos.SelectedRows[0];
                Categoria categoria;
                if (r.Tag != null)
                {
                    categoria = (Categoria)r.Tag;
                    Categoria categoriaCopia=(Categoria)categoria.Clone();
                    FrmCategoriasAE frm = new FrmCategoriasAE { Text = "Editar Categoria" };
                    frm.SetTipo(categoria);
                    DialogResult dr = frm.ShowDialog(this);

                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    categoria = frm.GetTipo();

                    if (!_servicio!.Existe(categoria))       // Si no existe la Categoria, lo edita
                    {
                        // Servicios ordena a Datos que guarde la edición en la BASE DE DATOS
                        _servicio!.Guardar(categoria);
                        GridHelper.SetearFila(r, categoria);    // Agrega los datos en las celdas de una la fila que YA ESTÁ CREADA.
                        MessageBox.Show("Categoria editada satisfactoriamente",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        GridHelper.SetearFila(r,categoriaCopia);
                        MessageBox.Show("Registro existente\nEdición denegada",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception)
            {

            }
        }
    }
}
