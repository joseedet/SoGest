
using System;

namespace SoGest.Data.Model.Entities
{
    public class Proveedor : IBaseUsuario
    {
        public int Id { get; set; }
        public int TipoDocumentoId { get; set; }
        public int Documento { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string CodPostal { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string NombreContacto { get; set; }
        public string ApellidoContacto { get; set; }
        public string Fijo { get; set; }
        public string Movil { get; set; }
        public string Correo { get; set; }
        public string Foto { get; set; }
        public string Notas { get; set; }
        public DateTime? Aniversario { get; set; }
        public bool Activo { get; set; }
    }  
}
