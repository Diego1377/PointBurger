using PointBurger.Entidades.Dtos;
using PointBurger.Entidades.Entidades;

namespace PointBurger.Windows.Helpers
{
    public static class GridHelper
    {
        public static void MostrarDatosEnGrilla<T>(List<T> lista, DataGridView dgv) where T : class
        {
            LimpiarGrilla(dgv);
            foreach (var item in lista)
            {
                var r = ConstruirFila(dgv);
                SetearFila(r, item);
                AgregarFila(r, dgv);
            }
        }
        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Categoria categoria:
                    r.Cells[0].Value = categoria.Nombre;
                    break;
                case EmpleadosListDto empleado:
                    r.Cells[0].Value = empleado.EmpleadoID;
                    r.Cells[1].Value = empleado.Nombre;
                    r.Cells[2].Value = empleado.Apellido;
                    r.Cells[3].Value = empleado.Salario;
                    r.Cells[4].Value = empleado.Telefono;
                    r.Cells[5].Value = empleado.FechaNac.ToShortDateString();
                    r.Cells[6].Value = empleado.Comision;
                    break;
                case ProductosListDto producto:
                    r.Cells[0].Value = producto.ProductoId;
                    r.Cells[1].Value = producto.NombreCategoria;
                    r.Cells[2].Value = producto.Nombre;
                    r.Cells[4].Value = producto.PrecioCosto;
                    r.Cells[5].Value = producto.PrecioVenta;
                    r.Cells[6].Value = producto.Stock;
                    break;
                default:
                    break;
            }
            r.Tag = obj;
        }
        public static void AgregarFila(DataGridViewRow r,
           DataGridView grid)
        {
            grid.Rows.Add(r);
        }
        public static void QuitarFila(DataGridViewRow r,
            DataGridView grid)
        {
            grid.Rows.Remove(r);
        }
        public static int ObtenerRowIndex(DataGridView dgv, int id)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var row = dgv.Rows[i];
                if ((int)row.Cells[0].Value == id)
                {
                    return i;
                }
            }
            return -1;

        }

        public static void MarcarRow(DataGridView dgvDatos, int rowIndex)
        {
            if (rowIndex >= 0)
            {
                dgvDatos.Rows[rowIndex].Selected = true;
                dgvDatos.FirstDisplayedScrollingRowIndex = rowIndex;
            }

        }
    }
}
