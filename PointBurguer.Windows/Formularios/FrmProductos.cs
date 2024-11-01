using Microsoft.Extensions.DependencyInjection;
using PointBurger.Entidades.Dtos;
using PointBurger.Entidades.Entidades;
using PointBurger.Windows.Formularios;
using PointBurger.Windows.Helpers;
using PointBurguer.Servicios.Interfaces;

namespace PointBurguer.Windows.Formularios
{
    public partial class FrmProductos : Form
    {
        private List<ProductosListDto> lista = null!;
        private readonly IServiciosProductos? _servicio;
        private readonly IServiceProvider? _serviceProvider;

        private int currentPage = 1;
        private int totalPages = 0;
        private int pageSize = 10;
        private int totalRecords = 0;
        private Func<ProductosListDto, bool>? filter = null;

        public FrmProductos(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicio = serviceProvider?.GetService<IServiciosProductos>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                totalRecords = _servicio!.GetCantidad(filter);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                LoadData(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadData(Func<ProductosListDto, bool>? filter)
        {
            try
            {
                lista = _servicio!.GetLista(currentPage, pageSize, filter);
                if (lista.Count > 0)
                {
                    MostrarDatosEnGrilla(lista);
                    if (cboPaginas.Items.Count != totalPages)
                    {
                        CombosHelper.CargarComboPaginas(ref cboPaginas, totalPages);
                    }
                    txtCantidadPaginas.Text = totalPages.ToString();
                    cboPaginas.SelectedIndexChanged -= cboPaginas_SelectedIndexChanged;
                    cboPaginas.SelectedIndex = currentPage == 1 ? 0 : currentPage - 1;
                    cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged;

                }
                else
                {
                    MessageBox.Show("No se encontraron registros!!!", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("No hay registros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentPage = 1;
                    filter = null;
                    //tsbFiltrar.Enabled = true;
                    //tsbFiltrar.BackColor = SystemColors.Control;
                    RecargarGrilla();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cboPaginas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            currentPage = int.Parse(cboPaginas.Text);
            LoadData(filter);
        }

        private void MostrarDatosEnGrilla(List<ProductosListDto> lista)
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            if (lista is not null)
            {
                foreach (var b in lista)
                {
                    var r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, b);
                    GridHelper.AgregarFila(r, dgvDatos);
                }

            }
        }
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData(filter);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData(filter);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadData(filter);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData(filter);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProductosAE frm = new FrmProductosAE(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Producto? producto = frm.GetProducto();
                if (producto is null)
                {
                    return;
                }
                if (!_servicio!.Existe(producto))
                {
                    _servicio.Guardar(producto);
                    totalRecords = _servicio!.GetCantidad(filter);
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    LoadData(filter);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;

            var productoDto = (ProductosListDto)r.Tag;

            try
            {
                DialogResult dr = MessageBox.Show($@"¿Desea dar de baja al Producto {productoDto.Nombre}?",
                        "Confirmar Baja",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                if (dr == DialogResult.Yes)
                {
                    _servicio!.Borrar(productoDto.ProductoId);
                    GridHelper.QuitarFila(r, dgvDatos);
                    MessageBox.Show("Registro eliminado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }



                else
                {
                    MessageBox.Show("Baja Denegada",
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FrmFiltroTexto frm = new FrmFiltroTexto() { Text = "Ingresar un texto para buscar..." };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro is null || textoFiltro == string.Empty) return;

                filter = b => (b.Nombre.ToUpper().Contains(textoFiltro.ToUpper()));
                //|| (b.NombreCategoria!.ToUpper().Contains(textoFiltro.ToUpper())));
                totalRecords = _servicio!.GetCantidad(filter);
                currentPage = 1;
                if (totalRecords > 0)
                {
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    btnFiltrar.Enabled = false;
                    btnFiltrar.BackColor = Color.OrangeRed;
                    LoadData(filter);
                }
                else
                {
                    MessageBox.Show("No se encontraron registros..",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    filter = null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            filter = null;
            currentPage = 1;
            btnFiltrar.Enabled = true;
            btnFiltrar.BackColor = Color.Empty;
            RecargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag == null) return;
            ProductosListDto productoDto = (ProductosListDto)r.Tag;
            Producto? producto = _servicio!?.GetProductoPorId(productoDto.ProductoId);
            if (producto is null) return;
            FrmProductosAE frm = new FrmProductosAE(_serviceProvider) { Text = "Editar Producto" };
            frm.SetTipo(producto);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            producto = frm.GetTipo();
            if (producto == null) return;
            try
            {
                if (!_servicio!.Existe(producto))
                {
                    _servicio!.Guardar(producto);
                    LoadData(filter);
                    GridHelper.SetearFila(r, producto);
                    MessageBox.Show("Registro editado",
                                    "Mensaje",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente\nEdición denegada",
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
    }
}
