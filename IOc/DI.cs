using Microsoft.Extensions.DependencyInjection;
using PointBurger.Datos.Interfaces;
using PointBurger.Datos.Repositorios;
using PointBurguer.Servicios.Interfaces;
using PointBurguer.Servicios.Servicios;
using System.Configuration;
using System.Reflection.Metadata.Ecma335;

namespace IOc
{
    public static class DI
    {
        public static IServiceProvider ConfigurarServicios()
        {
            var servicios = new ServiceCollection();
            var cadena = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();

            servicios.AddScoped<IRepositorioCategorias, RepositorioCategorias>();
            servicios.AddScoped<IRepositorioEmpleados, RepositorioEmpleados>();
            servicios.AddScoped<IRepositorioProductos, RepositorioProductos>();

            servicios.AddScoped<IServiciosCategorias>(sp =>
            {
            var repositorio = new RepositorioCategorias();
            return new ServiciosCategorias(repositorio, cadena);
            });
            servicios.AddScoped<IServiciosEmpleados>(sp =>
            {
                var repositorio = new RepositorioEmpleados();
                return new ServiciosEmpleados(repositorio, cadena);
            });
            servicios.AddScoped<IServiciosProductos>(sp =>
            {
                var repositorio = new RepositorioProductos();
                return new ServiciosProductos(repositorio, cadena);
            });












            return servicios.BuildServiceProvider();

        }

    }
}
