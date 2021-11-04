namespace SoGest.Data.Model.Interfaces
{
    public interface IBase:IBaseEntity
    {
        //public int Id { get; set; }
        public string Descripcion { get; set; }

        public bool Activo { get; set; }

    }
}
