namespace PointBurger.Entidades.Entidades
{
    public class Categoria:ICloneable
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; } = null!;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
