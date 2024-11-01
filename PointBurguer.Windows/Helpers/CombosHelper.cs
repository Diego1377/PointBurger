using Microsoft.Extensions.DependencyInjection;
using PointBurger.Entidades.Entidades;
using PointBurguer.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointBurger.Windows.Helpers
{
    public static class CombosHelper
    {
        private static IServiceProvider? _serviceProvider;

        public static void CargarComboPaginas(ref ComboBox cbo, int totalPages)
        {
            cbo.Items.Clear();
            for (int i = 1; i <= totalPages; i++)
            {
                cbo.Items.Add(i.ToString());
            }

        }

        internal static void CargarComboTiposDeCategoria(ref ComboBox cboCategorias, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosCategorias? servicio = _serviceProvider!.GetService<IServiciosCategorias>();
            var lista = servicio!.GetLista();
            var defaultTipo = new Categoria()
            {
                CategoriaId = 0,
                Nombre = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cboCategorias.DataSource = lista;
            cboCategorias.DisplayMember = "Nombre";
            cboCategorias.ValueMember = "CategoriaId";
            cboCategorias.SelectedIndex = 0;
        }
    }
}
