using PointBurger.Entidades.Entidades;
using PointBurger.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PointBurger.Windows.Formularios
{
    public partial class FrmProductosAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imágenes\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\Imágenes\ArchivoNoEncontrado.jpg";
        private string? archivoImagen = string.Empty;
        private string carpetaImagen = Environment.CurrentDirectory + @"\Imágenes\";
        public FrmProductosAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        private Producto? producto;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboTiposDeCategoria(ref cboCategorias, _serviceProvider);
            if (producto is not null)
            {
                txtProducto.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                cboCategorias.SelectedValue = producto.CategoriaId;
                nupPrecioC.Value = producto.PrecioCosto;
                nupPrecioV.Value = producto.PrecioVenta;
                nupStock.Value = producto.Stock;
                chkSuspendido.Checked = producto.Suspendido;

                //Veo si el producto tiene alguna imagen asociada
                if (producto.Imagen != string.Empty)
                {
                    //Me aseguro que esa imagen exista
                    if (!File.Exists($"{carpetaImagen}{producto.Imagen}"))
                    {
                        //Si no existe, muestro la imagen de archivo no encontrado
                        picImagen.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        //Caso contrario muestro la imagen
                        picImagen.Image = Image.FromFile($"{carpetaImagen}{producto.Imagen}");
                        archivoImagen = producto.Imagen;
                    }
                }
                else
                {
                    //Si no tiene imagen muestro Sin Imagen 
                    picImagen.Image = Image.FromFile(imagenNoDisponible);
                }

            }

        }
        public Producto? GetProducto()
        {
            return producto;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (producto is null)
                {
                    producto = new Producto();
                }

                producto.Nombre = txtProducto.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.CategoriaId = (int)cboCategorias.SelectedValue!;
                producto.PrecioCosto = (int)nupPrecioC.Value;
                producto.PrecioVenta = (int)nupPrecioV.Value;
                producto.Stock = (int)nupStock.Value;
                //Falta img
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(txtProducto.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtProducto, "Ingrese un Nombre");
            }
            if (cboCategorias.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboCategorias, "Ingrese la categoria del producto");
            }
            if (string.IsNullOrEmpty(nupPrecioC.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(nupPrecioC, "Ingrese el Precio Costo del producto");

            }
            return valido;
        }

        public void SetTipo(Producto producto)
        {
            this.producto = producto;
        }

        public Producto? GetTipo()
        {
            return producto;
        }
    }
}
