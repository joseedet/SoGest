using SoGest.Data.Model.Interfaces;

namespace SoGest.Data.Model.Entities
{
    public class IVA : IBase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Tarifa { get; set; }
        public bool Activo { get; set; }
    }
}
