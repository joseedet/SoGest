using SoGest.Data.Model.Interfaces;

namespace SoGest.Data.Model.Entities
{
    public class Almacen : IBase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
