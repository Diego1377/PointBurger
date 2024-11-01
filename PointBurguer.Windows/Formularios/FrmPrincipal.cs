using Microsoft.Extensions.DependencyInjection;
using PointBurguer.Servicios.Interfaces;
using PointBurguer.Windows.Formularios;
using System;


namespace PointBurguer.Windows
{
    public partial class FrmPrincipal : Form
    {
        private readonly IServiceProvider serviceProvider;
        public FrmPrincipal(IServiceProvider _serviceProvider)
        {
            InitializeComponent();
            serviceProvider = _serviceProvider;
           
        }
        private void AbrirFormularioEnPanel(object FormularioHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form? fh = FormularioHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmCategorias(serviceProvider));
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmProductos(serviceProvider));
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmEmpleados(serviceProvider));
        }

       
    }
}
